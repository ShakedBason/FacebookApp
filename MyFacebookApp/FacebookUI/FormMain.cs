using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookUI
{
    public partial class FormMain : Form
    {
        private readonly FacadeFormMain r_FacadeFormMain = new FacadeFormMain();

        public FormMain()
        {
            InitializeComponent();
            r_FacadeFormMain.AlbumsSortStrategyChanged += r_FacadeFormMain_AlbumsSortStrategyChanged;
        }

        private void r_FacadeFormMain_AlbumsSortStrategyChanged(object sender, EventArgs e)
        {
            new Thread(fetchSortedAlbums).Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (r_FacadeFormMain.LastWindowsLocation.HasValue)
            {
                this.Location = r_FacadeFormMain.LastWindowsLocation.Value;
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            fetchFacebookInfo();
        }

        private void fetchFacebookInfo()
        {
            labelHelloUser.Text = $"Hello, {r_FacadeFormMain.UserFullName} :)";
            pictureBoxProfilePicture.LoadAsync(r_FacadeFormMain.UserProfilePictureURL);
            fetchAboutMe();
            new Thread(fetchSortedAlbums).Start();
            new Thread(fetchLikedPages).Start();
            new Thread(fetchFriends).Start();
            new Thread(fetchPosts).Start();
            new Thread(fetchUpcomingEvents).Start();
            new Thread(fetchThisWeekEvents).Start();
            new Thread(delegate () { fetchCelebrators(monthCalenderBirthdays.SelectionRange.Start, birthdayListBox, birthdayUserBindingSource); }).Start();
            new Thread(delegate () { fetchCelebrators(DateTime.Today, listBoxTodayBirthdays, todayCelebratorsUsersBindingSource); }).Start();
        }

        private void fetchAboutMe()
        {
            labelEmail.Text = r_FacadeFormMain.UserEmail;
            labelBirthday.Text = r_FacadeFormMain.UserBirthday;

            if (r_FacadeFormMain.UserGender.HasValue)
            {
                labelGender.Text = r_FacadeFormMain.UserGender.Value.ToString();
            }

            if(r_FacadeFormMain.UserRelationshipStatus.HasValue)
            {
                labelRelationshipStatus.Text = r_FacadeFormMain.UserRelationshipStatus.Value.ToString();
            }
        }

        private void fetchPosts()
        {
            FacebookObjectCollection<Post> userPosts = r_FacadeFormMain.UserPosts;

            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));

            foreach (Post post in userPosts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }
        }

        private void fetchLikedPages()
        {
            setBindingSourceDataSource(pageBindingSource, r_FacadeFormMain.UserLikedPages);
        }

        private void radioButtonSortAlbums_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                eSortValues sortValue;

                if (radioButton == radioButtonCreatedDate)
                {
                    sortValue = eSortValues.CreatedTime;
                }
                else if (radioButton == radioButtonMostLiked)
                {
                    sortValue = eSortValues.LikesAmount;
                }
                else
                {
                    sortValue = eSortValues.UpdateTime;
                }

                r_FacadeFormMain.SetAlbumsSortStrategy(sortValue);
            }
        }

        private void fetchSortedAlbums()
        {
            List<Album> sortedUserAlbums = r_FacadeFormMain.GetUserSortedAlbums();

            setBindingSourceDataSource(albumBindingSource, sortedUserAlbums);

            if (listBoxAlbums.Items.Count != 0)
            {
                displayTop3AlbumsPicture(sortedUserAlbums);
            }
        }

        private void displayTop3AlbumsPicture(List<Album> i_sortedUserAlbums)
        {
            PictureBox[] top3AlbumsPictures = { pictureBox1stAlbumPicture, pictureBox2ndAlbumPicture, pictureBox3rdAlbumPicture };
            Label[] top3AlbumsLabels = { label1stAlbumName, label2ndAlbumName, label3rdAlbumName };

            for (int i = 0; i < 3; i++)
            {
                if (i < i_sortedUserAlbums.Count)
                {
                    top3AlbumsPictures[i].Invoke(new Action(() => top3AlbumsPictures[i].Cursor = Cursors.Hand));
                    top3AlbumsPictures[i].LoadAsync(i_sortedUserAlbums[i].PictureAlbumURL);
                    top3AlbumsLabels[i].Invoke(new Action(() => top3AlbumsLabels[i].Text = i_sortedUserAlbums[i].Name));
                }
                else
                {
                    top3AlbumsPictures[i].Invoke(new Action(() => top3AlbumsPictures[i].Cursor = Cursors.Default));
                    top3AlbumsPictures[i].Invoke(new Action(() => top3AlbumsPictures[i].Image = null));
                    top3AlbumsLabels[i].Invoke(new Action(() => top3AlbumsLabels[i].Text = string.Empty));
                }
            }
        }
        
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItem != null)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

                new Thread(delegate () { setAnAlbumAsSlideShowDataSource(selectedAlbum); }).Start();
            }
        }

        private void setAnAlbumAsSlideShowDataSource(Album i_SelectedAlbum)
        {
            setBindingSourceDataSource(photoBindingSource, i_SelectedAlbum.Photos);
        }

        private void photoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            displayCurrentPhoto();
        }

        private void photoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            displayCurrentPhoto();
        }

        private void displayCurrentPhoto()
        {
            if (photoBindingSource.Count > 0)
            {
                Photo currentPhoto = bindingNavigatorSelectedAlbumPhotos.BindingSource.Current as Photo;

                if (currentPhoto.PictureAlbumURL != null)
                {
                    pictureBoxSelectedAlbumCurrentPhoto.LoadAsync(currentPhoto.PictureAlbumURL);
                }
                else
                {
                    pictureBoxSelectedAlbumCurrentPhoto.Image = pictureBoxSelectedAlbumCurrentPhoto.ErrorImage;
                }
            }
            else
            {
                pictureBoxSelectedAlbumCurrentPhoto.Image = null;
            }
        }

        private void fetchCelebrators(DateTime i_BirthdayDate, ListBox i_ListBoxToFill, BindingSource i_UserBindingSource)
        {
            setBindingSourceDataSource(i_UserBindingSource, r_FacadeFormMain.GetCelebratorsByDate(i_BirthdayDate));
        }

        private void fetchFriends()
        {
            setBindingSourceDataSource(friendBindingSource, r_FacadeFormMain.UserFriends);
        }

        private void fetchUpcomingEvents()
        {
            setBindingSourceDataSource(eventBindingSource, r_FacadeFormMain.UserEvents);
        }

        private void fetchThisWeekEvents()
        {
            setBindingSourceDataSource(thisWeekEventBindingSource, r_FacadeFormMain.GetUserThisWeekEvents());
        }

        private void buttonPostNewStatus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBoxNewStatus.Text))
            {
                postNewStatus(richTextBoxNewStatus.Text);
                restorePostStatusTextboxText();
            }
            else
            {
                MessageBox.Show("What's the point in posting an empty status? o.O");
            }
        }

        private void postNewStatus(string i_StatusText, string i_TaggedFriendId = null)
        {
            try
            {
                Status postedStatus = r_FacadeFormMain.PostStatus(i_StatusText, i_TaggedFriendId);
                MessageBox.Show("Status Posted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBoxNewStatus_Enter(object sender, EventArgs e)
        {
            richTextBoxNewStatus.Clear();
        }

        private void richTextBoxNewStatus_Leave(object sender, EventArgs e)
        {
            if (!buttonPostNewStatus.Focused)
            {
                restorePostStatusTextboxText();
            }
        }

        private void restorePostStatusTextboxText()
        {
            richTextBoxNewStatus.Text = "What's on your mind?";
        }

        private void fetchBirthdaysAccordingCalenderDay_Click(object sender, EventArgs e)
        {
            fetchCelebrators(monthCalenderBirthdays.SelectionRange.Start, birthdayListBox, birthdayUserBindingSource);
        }

        private void buttonPostBirthdayBlessing_Click(object sender, EventArgs e)
        {
            if (monthCalenderBirthdays.SelectionRange.Start == DateTime.Today)
            {
                if (birthdayListBox.SelectedItems.Count == 1)
                {
                    postBirthdayBlessing();
                }
                else
                {
                    MessageBox.Show("Choose a friend in order to post a blessing");
                }
            }
            else
            {
                MessageBox.Show("You can post birthday blessing only for friends that celebrating today");
            }
        }

        private void postBirthdayBlessing()
        {
            string birthdayFriendId = (birthdayListBox.SelectedItem as User).Id;

            if (radioButtonWriteABirthdayPost.Checked && string.IsNullOrWhiteSpace(richBoxPostBirthdayBlessing.Text))
            {
                MessageBox.Show("What's the point in posting an empty blessing? o.O");
            }
            else
            {
                string birthdayBlessing = radioButtonWriteABirthdayPost.Checked ? richBoxPostBirthdayBlessing.Text : tabBirthdays.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked).Text;
                postNewStatus(string.Format("{0}", birthdayBlessing), birthdayFriendId);
            }
        }

        private void pictureBoxTopAlbum_Click(object sender, EventArgs e)
        {
            PictureBox pictureBoxTopAlbum = sender as PictureBox;
            int listBoxAlbumsIndex;

            if (pictureBoxTopAlbum == pictureBox1stAlbumPicture)
            {
                listBoxAlbumsIndex = 0;
            }
            else if (pictureBoxTopAlbum == pictureBox2ndAlbumPicture)
            {
                listBoxAlbumsIndex = 1;
            }
            else
            {
                listBoxAlbumsIndex = 2;
            }

            listBoxAlbums.SelectedIndex = listBoxAlbumsIndex;
        }

        private void setBindingSourceDataSource(BindingSource i_BindingSource, object i_DataSource)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<BindingSource, object>(setBindingSourceDataSource), i_BindingSource, i_DataSource);
            }
            else
            {
                i_BindingSource.DataSource = i_DataSource;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_FacadeFormMain.Logout();
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            r_FacadeFormMain.UpdateAndSaveAppSettings(this.Location);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
