namespace FacebookUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lableAttendingCount;
            System.Windows.Forms.Label labelDescription;
            System.Windows.Forms.Label labelEndTime;
            System.Windows.Forms.Label lableLocation;
            System.Windows.Forms.Label labelStartTime;
            System.Windows.Forms.Label lableMaybeCount;
            System.Windows.Forms.Label lablePageCategory;
            System.Windows.Forms.Label lablePageLikesCount;
            System.Windows.Forms.Label lableLikedPageDescription;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.richTextBoxNewStatus = new System.Windows.Forms.RichTextBox();
            this.buttonPostNewStatus = new System.Windows.Forms.Button();
            this.todayCelebratorsUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.listBoxPosts = new FacebookUI.MyListBox();
            this.listBoxTodayBirthdays = new FacebookUI.MyListBox();
            this.listBoxUpcomingEventsThisWeek = new FacebookUI.MyListBox();
            this.thisWeekEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxFriendsList = new FacebookUI.MyListBox();
            this.labelMyFriends = new System.Windows.Forms.Label();
            this.labeThisWeekEvents = new System.Windows.Forms.Label();
            this.labelBirthdays = new System.Windows.Forms.Label();
            this.TabAlbums = new System.Windows.Forms.TabPage();
            this.panelSelectedAlbumPhotos = new System.Windows.Forms.Panel();
            this.pictureBoxSelectedAlbumCurrentPhoto = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorSelectedAlbumPhotos = new System.Windows.Forms.BindingNavigator(this.components);
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listBoxAlbums = new FacebookUI.MyListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonLastUpdate = new System.Windows.Forms.RadioButton();
            this.labelAlbumsInstruction = new System.Windows.Forms.Label();
            this.labelOrderAlbumsBy = new System.Windows.Forms.Label();
            this.label3rdAlbumName = new System.Windows.Forms.Label();
            this.label2ndAlbumName = new System.Windows.Forms.Label();
            this.label1stAlbumName = new System.Windows.Forms.Label();
            this.pictureBox3rdAlbumPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2ndAlbumPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1stAlbumPicture = new System.Windows.Forms.PictureBox();
            this.radioButtonCreatedDate = new System.Windows.Forms.RadioButton();
            this.radioButtonMostLiked = new System.Windows.Forms.RadioButton();
            this.tabBirthdays = new System.Windows.Forms.TabPage();
            this.birthdayListBox = new FacebookUI.MyListBox();
            this.birthdayUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lablePostBirthdayBlessingInstructions = new System.Windows.Forms.Label();
            this.buttonPostBirthdayBlessing = new System.Windows.Forms.Button();
            this.richBoxPostBirthdayBlessing = new System.Windows.Forms.RichTextBox();
            this.radioButtonWriteABirthdayPost = new System.Windows.Forms.RadioButton();
            this.radioButtonBirthdayBlessing5 = new System.Windows.Forms.RadioButton();
            this.radioButtonBirthdayBlessing4 = new System.Windows.Forms.RadioButton();
            this.radioButtonBirrthdayBlessing3 = new System.Windows.Forms.RadioButton();
            this.radioButtonBirthdayBlessing2 = new System.Windows.Forms.RadioButton();
            this.radioButtonBirthdayBlessing1 = new System.Windows.Forms.RadioButton();
            this.fetchBirthdaysAccordingCalenderDay = new System.Windows.Forms.Button();
            this.labelCalenderInstructions = new System.Windows.Forms.Label();
            this.monthCalenderBirthdays = new System.Windows.Forms.MonthCalendar();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.panelMyEventsTab = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxUserEvents = new FacebookUI.MyListBox();
            this.lableMaybeCountDetails = new System.Windows.Forms.Label();
            this.lableAttendingCountDetails = new System.Windows.Forms.Label();
            this.lableEventDescription = new System.Windows.Forms.Label();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.lableLocationDetails = new System.Windows.Forms.Label();
            this.labelMyEvents = new System.Windows.Forms.Label();
            this.tabLikedPages = new System.Windows.Forms.TabPage();
            this.panelLikedPagesTab = new System.Windows.Forms.Panel();
            this.listBoxLikedPages = new FacebookUI.MyListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableLikedPageDescriptionDetails = new System.Windows.Forms.Label();
            this.likesCountLabel1 = new System.Windows.Forms.Label();
            this.lablePageCategoryDetails = new System.Windows.Forms.Label();
            this.PictureBoxPageProfile = new System.Windows.Forms.PictureBox();
            this.labelLikedPagesTab = new System.Windows.Forms.Label();
            this.tabAboutMe = new System.Windows.Forms.TabPage();
            this.panelAboutMe = new System.Windows.Forms.Panel();
            this.labelRelationshipStatus = new System.Windows.Forms.Label();
            this.labelRelationshipStatusTitle = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelGenderTitle = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelBirthdayTitle = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEmailTitle = new System.Windows.Forms.Label();
            this.lableAboutMe = new System.Windows.Forms.Label();
            this.labelHelloUser = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bindingSourceAboutMe = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            lableAttendingCount = new System.Windows.Forms.Label();
            labelDescription = new System.Windows.Forms.Label();
            labelEndTime = new System.Windows.Forms.Label();
            lableLocation = new System.Windows.Forms.Label();
            labelStartTime = new System.Windows.Forms.Label();
            lableMaybeCount = new System.Windows.Forms.Label();
            lablePageCategory = new System.Windows.Forms.Label();
            lablePageLikesCount = new System.Windows.Forms.Label();
            lableLikedPageDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todayCelebratorsUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thisWeekEventBindingSource)).BeginInit();
            this.TabAlbums.SuspendLayout();
            this.panelSelectedAlbumPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbumCurrentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSelectedAlbumPhotos)).BeginInit();
            this.bindingNavigatorSelectedAlbumPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3rdAlbumPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2ndAlbumPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1stAlbumPicture)).BeginInit();
            this.tabBirthdays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayUserBindingSource)).BeginInit();
            this.tabEvents.SuspendLayout();
            this.panelMyEventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.tabLikedPages.SuspendLayout();
            this.panelLikedPagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPageProfile)).BeginInit();
            this.tabAboutMe.SuspendLayout();
            this.panelAboutMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAboutMe)).BeginInit();
            this.SuspendLayout();
            // 
            // lableAttendingCount
            // 
            lableAttendingCount.AutoSize = true;
            lableAttendingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lableAttendingCount.Location = new System.Drawing.Point(238, 226);
            lableAttendingCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lableAttendingCount.Name = "lableAttendingCount";
            lableAttendingCount.Size = new System.Drawing.Size(72, 17);
            lableAttendingCount.TabIndex = 15;
            lableAttendingCount.Text = "Attending:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelDescription.Location = new System.Drawing.Point(238, 86);
            labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(83, 17);
            labelDescription.TabIndex = 17;
            labelDescription.Text = "Description:";
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelEndTime.Location = new System.Drawing.Point(238, 156);
            labelEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new System.Drawing.Size(72, 17);
            labelEndTime.TabIndex = 19;
            labelEndTime.Text = "End Time:";
            // 
            // lableLocation
            // 
            lableLocation.AutoSize = true;
            lableLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lableLocation.Location = new System.Drawing.Point(238, 191);
            lableLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lableLocation.Name = "lableLocation";
            lableLocation.Size = new System.Drawing.Size(66, 17);
            lableLocation.TabIndex = 23;
            lableLocation.Text = "Location:";
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelStartTime.Location = new System.Drawing.Point(238, 121);
            labelStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new System.Drawing.Size(77, 17);
            labelStartTime.TabIndex = 27;
            labelStartTime.Text = "Start Time:";
            // 
            // lableMaybeCount
            // 
            lableMaybeCount.AutoSize = true;
            lableMaybeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lableMaybeCount.Location = new System.Drawing.Point(238, 261);
            lableMaybeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lableMaybeCount.Name = "lableMaybeCount";
            lableMaybeCount.Size = new System.Drawing.Size(54, 17);
            lableMaybeCount.TabIndex = 28;
            lableMaybeCount.Text = "Maybe:";
            // 
            // lablePageCategory
            // 
            lablePageCategory.AutoSize = true;
            lablePageCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lablePageCategory.Location = new System.Drawing.Point(405, 181);
            lablePageCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lablePageCategory.Name = "lablePageCategory";
            lablePageCategory.Size = new System.Drawing.Size(104, 17);
            lablePageCategory.TabIndex = 12;
            lablePageCategory.Text = "Page category:";
            // 
            // lablePageLikesCount
            // 
            lablePageLikesCount.AutoSize = true;
            lablePageLikesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lablePageLikesCount.Location = new System.Drawing.Point(405, 215);
            lablePageLikesCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lablePageLikesCount.Name = "lablePageLikesCount";
            lablePageLikesCount.Size = new System.Drawing.Size(45, 17);
            lablePageLikesCount.TabIndex = 13;
            lablePageLikesCount.Text = "Likes:";
            // 
            // lableLikedPageDescription
            // 
            lableLikedPageDescription.AutoSize = true;
            lableLikedPageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lableLikedPageDescription.Location = new System.Drawing.Point(405, 247);
            lableLikedPageDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lableLikedPageDescription.Name = "lableLikedPageDescription";
            lableLikedPageDescription.Size = new System.Drawing.Size(83, 17);
            lableLikedPageDescription.TabIndex = 14;
            lableLikedPageDescription.Text = "Description:";
            // 
            // richTextBoxNewStatus
            // 
            this.richTextBoxNewStatus.Location = new System.Drawing.Point(186, 120);
            this.richTextBoxNewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxNewStatus.Name = "richTextBoxNewStatus";
            this.richTextBoxNewStatus.Size = new System.Drawing.Size(393, 65);
            this.richTextBoxNewStatus.TabIndex = 56;
            this.richTextBoxNewStatus.Text = "What\'s on your mind?";
            this.richTextBoxNewStatus.Enter += new System.EventHandler(this.richTextBoxNewStatus_Enter);
            this.richTextBoxNewStatus.Leave += new System.EventHandler(this.richTextBoxNewStatus_Leave);
            // 
            // buttonPostNewStatus
            // 
            this.buttonPostNewStatus.Location = new System.Drawing.Point(506, 184);
            this.buttonPostNewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPostNewStatus.Name = "buttonPostNewStatus";
            this.buttonPostNewStatus.Size = new System.Drawing.Size(72, 21);
            this.buttonPostNewStatus.TabIndex = 58;
            this.buttonPostNewStatus.Text = "Post";
            this.buttonPostNewStatus.UseVisualStyleBackColor = true;
            this.buttonPostNewStatus.Click += new System.EventHandler(this.buttonPostNewStatus_Click);
            // 
            // todayCelebratorsUsersBindingSource
            // 
            this.todayCelebratorsUsersBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // friendBindingSource
            // 
            this.friendBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.TabAlbums);
            this.tabControl.Controls.Add(this.tabBirthdays);
            this.tabControl.Controls.Add(this.tabEvents);
            this.tabControl.Controls.Add(this.tabLikedPages);
            this.tabControl.Controls.Add(this.tabAboutMe);
            this.tabControl.Location = new System.Drawing.Point(6, 9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 557);
            this.tabControl.TabIndex = 68;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.listBoxPosts);
            this.tabHome.Controls.Add(this.listBoxTodayBirthdays);
            this.tabHome.Controls.Add(this.listBoxUpcomingEventsThisWeek);
            this.tabHome.Controls.Add(this.listBoxFriendsList);
            this.tabHome.Controls.Add(this.labelMyFriends);
            this.tabHome.Controls.Add(this.labeThisWeekEvents);
            this.tabHome.Controls.Add(this.labelBirthdays);
            this.tabHome.Controls.Add(this.richTextBoxNewStatus);
            this.tabHome.Controls.Add(this.buttonPostNewStatus);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Margin = new System.Windows.Forms.Padding(2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(2);
            this.tabHome.Size = new System.Drawing.Size(782, 531);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(186, 231);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(393, 290);
            this.listBoxPosts.TabIndex = 79;
            // 
            // listBoxTodayBirthdays
            // 
            this.listBoxTodayBirthdays.DataSource = this.todayCelebratorsUsersBindingSource;
            this.listBoxTodayBirthdays.DisplayMember = "Name";
            this.listBoxTodayBirthdays.FormattingEnabled = true;
            this.listBoxTodayBirthdays.Location = new System.Drawing.Point(13, 335);
            this.listBoxTodayBirthdays.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTodayBirthdays.Name = "listBoxTodayBirthdays";
            this.listBoxTodayBirthdays.Size = new System.Drawing.Size(162, 160);
            this.listBoxTodayBirthdays.TabIndex = 78;
            // 
            // listBoxUpcomingEventsThisWeek
            // 
            this.listBoxUpcomingEventsThisWeek.DataSource = this.thisWeekEventBindingSource;
            this.listBoxUpcomingEventsThisWeek.DisplayMember = "Description";
            this.listBoxUpcomingEventsThisWeek.FormattingEnabled = true;
            this.listBoxUpcomingEventsThisWeek.Location = new System.Drawing.Point(13, 153);
            this.listBoxUpcomingEventsThisWeek.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUpcomingEventsThisWeek.Name = "listBoxUpcomingEventsThisWeek";
            this.listBoxUpcomingEventsThisWeek.Size = new System.Drawing.Size(162, 134);
            this.listBoxUpcomingEventsThisWeek.TabIndex = 77;
            this.listBoxUpcomingEventsThisWeek.ValueMember = "AttendingCount";
            // 
            // thisWeekEventBindingSource
            // 
            this.thisWeekEventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.DataSource = this.friendBindingSource;
            this.listBoxFriendsList.DisplayMember = "Name";
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.Location = new System.Drawing.Point(592, 153);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(168, 342);
            this.listBoxFriendsList.TabIndex = 76;
            // 
            // labelMyFriends
            // 
            this.labelMyFriends.AutoSize = true;
            this.labelMyFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyFriends.Location = new System.Drawing.Point(592, 131);
            this.labelMyFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyFriends.Name = "labelMyFriends";
            this.labelMyFriends.Size = new System.Drawing.Size(77, 17);
            this.labelMyFriends.TabIndex = 73;
            this.labelMyFriends.Text = "My Friends";
            // 
            // labeThisWeekEvents
            // 
            this.labeThisWeekEvents.AutoSize = true;
            this.labeThisWeekEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeThisWeekEvents.Location = new System.Drawing.Point(13, 131);
            this.labeThisWeekEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeThisWeekEvents.Name = "labeThisWeekEvents";
            this.labeThisWeekEvents.Size = new System.Drawing.Size(122, 17);
            this.labeThisWeekEvents.TabIndex = 70;
            this.labeThisWeekEvents.Text = "This Week Events";
            // 
            // labelBirthdays
            // 
            this.labelBirthdays.AutoSize = true;
            this.labelBirthdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdays.Location = new System.Drawing.Point(13, 313);
            this.labelBirthdays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthdays.Name = "labelBirthdays";
            this.labelBirthdays.Size = new System.Drawing.Size(67, 17);
            this.labelBirthdays.TabIndex = 68;
            this.labelBirthdays.Text = "Birthdays";
            // 
            // TabAlbums
            // 
            this.TabAlbums.AutoScroll = true;
            this.TabAlbums.BackColor = System.Drawing.Color.White;
            this.TabAlbums.Controls.Add(this.panelSelectedAlbumPhotos);
            this.TabAlbums.Controls.Add(this.listBoxAlbums);
            this.TabAlbums.Controls.Add(this.radioButtonLastUpdate);
            this.TabAlbums.Controls.Add(this.labelAlbumsInstruction);
            this.TabAlbums.Controls.Add(this.labelOrderAlbumsBy);
            this.TabAlbums.Controls.Add(this.label3rdAlbumName);
            this.TabAlbums.Controls.Add(this.label2ndAlbumName);
            this.TabAlbums.Controls.Add(this.label1stAlbumName);
            this.TabAlbums.Controls.Add(this.pictureBox3rdAlbumPicture);
            this.TabAlbums.Controls.Add(this.pictureBox2ndAlbumPicture);
            this.TabAlbums.Controls.Add(this.pictureBox1stAlbumPicture);
            this.TabAlbums.Controls.Add(this.radioButtonCreatedDate);
            this.TabAlbums.Controls.Add(this.radioButtonMostLiked);
            this.TabAlbums.Location = new System.Drawing.Point(4, 22);
            this.TabAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.TabAlbums.Name = "TabAlbums";
            this.TabAlbums.Padding = new System.Windows.Forms.Padding(2);
            this.TabAlbums.Size = new System.Drawing.Size(782, 531);
            this.TabAlbums.TabIndex = 1;
            this.TabAlbums.Text = "Albums";
            // 
            // panelSelectedAlbumPhotos
            // 
            this.panelSelectedAlbumPhotos.Controls.Add(this.pictureBoxSelectedAlbumCurrentPhoto);
            this.panelSelectedAlbumPhotos.Controls.Add(this.bindingNavigatorSelectedAlbumPhotos);
            this.panelSelectedAlbumPhotos.Location = new System.Drawing.Point(442, 230);
            this.panelSelectedAlbumPhotos.Name = "panelSelectedAlbumPhotos";
            this.panelSelectedAlbumPhotos.Size = new System.Drawing.Size(242, 249);
            this.panelSelectedAlbumPhotos.TabIndex = 81;
            // 
            // pictureBoxSelectedAlbumCurrentPhoto
            // 
            this.pictureBoxSelectedAlbumCurrentPhoto.Location = new System.Drawing.Point(31, 62);
            this.pictureBoxSelectedAlbumCurrentPhoto.Name = "pictureBoxSelectedAlbumCurrentPhoto";
            this.pictureBoxSelectedAlbumCurrentPhoto.Size = new System.Drawing.Size(174, 149);
            this.pictureBoxSelectedAlbumCurrentPhoto.TabIndex = 1;
            this.pictureBoxSelectedAlbumCurrentPhoto.TabStop = false;
            // 
            // bindingNavigatorSelectedAlbumPhotos
            // 
            this.bindingNavigatorSelectedAlbumPhotos.AddNewItem = null;
            this.bindingNavigatorSelectedAlbumPhotos.BindingSource = this.photoBindingSource;
            this.bindingNavigatorSelectedAlbumPhotos.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorSelectedAlbumPhotos.DeleteItem = null;
            this.bindingNavigatorSelectedAlbumPhotos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorSelectedAlbumPhotos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorSelectedAlbumPhotos.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorSelectedAlbumPhotos.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorSelectedAlbumPhotos.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorSelectedAlbumPhotos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorSelectedAlbumPhotos.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorSelectedAlbumPhotos.Name = "bindingNavigatorSelectedAlbumPhotos";
            this.bindingNavigatorSelectedAlbumPhotos.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorSelectedAlbumPhotos.Size = new System.Drawing.Size(242, 27);
            this.bindingNavigatorSelectedAlbumPhotos.TabIndex = 0;
            this.bindingNavigatorSelectedAlbumPhotos.Text = "bindingNavigator1";
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            this.photoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.photoBindingSource_BindingComplete);
            this.photoBindingSource.CurrentChanged += new System.EventHandler(this.photoBindingSource_CurrentChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(69, 304);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(240, 186);
            this.listBoxAlbums.TabIndex = 80;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // radioButtonLastUpdate
            // 
            this.radioButtonLastUpdate.AutoSize = true;
            this.radioButtonLastUpdate.Location = new System.Drawing.Point(217, 133);
            this.radioButtonLastUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLastUpdate.Name = "radioButtonLastUpdate";
            this.radioButtonLastUpdate.Size = new System.Drawing.Size(81, 17);
            this.radioButtonLastUpdate.TabIndex = 78;
            this.radioButtonLastUpdate.Text = "Last update";
            this.radioButtonLastUpdate.UseVisualStyleBackColor = true;
            this.radioButtonLastUpdate.CheckedChanged += new System.EventHandler(this.radioButtonSortAlbums_CheckedChanged);
            // 
            // labelAlbumsInstruction
            // 
            this.labelAlbumsInstruction.AutoSize = true;
            this.labelAlbumsInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumsInstruction.Location = new System.Drawing.Point(458, 150);
            this.labelAlbumsInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbumsInstruction.Name = "labelAlbumsInstruction";
            this.labelAlbumsInstruction.Size = new System.Drawing.Size(215, 48);
            this.labelAlbumsInstruction.TabIndex = 22;
            this.labelAlbumsInstruction.Text = "Select an album in order\r\nto see it\'s pictures \r\n";
            // 
            // labelOrderAlbumsBy
            // 
            this.labelOrderAlbumsBy.AutoSize = true;
            this.labelOrderAlbumsBy.Location = new System.Drawing.Point(19, 118);
            this.labelOrderAlbumsBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderAlbumsBy.Name = "labelOrderAlbumsBy";
            this.labelOrderAlbumsBy.Size = new System.Drawing.Size(86, 13);
            this.labelOrderAlbumsBy.TabIndex = 21;
            this.labelOrderAlbumsBy.Text = "Order albums by:";
            // 
            // label3rdAlbumName
            // 
            this.label3rdAlbumName.AutoSize = true;
            this.label3rdAlbumName.Location = new System.Drawing.Point(269, 266);
            this.label3rdAlbumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3rdAlbumName.Name = "label3rdAlbumName";
            this.label3rdAlbumName.Size = new System.Drawing.Size(0, 13);
            this.label3rdAlbumName.TabIndex = 20;
            // 
            // label2ndAlbumName
            // 
            this.label2ndAlbumName.AutoSize = true;
            this.label2ndAlbumName.Location = new System.Drawing.Point(143, 266);
            this.label2ndAlbumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2ndAlbumName.Name = "label2ndAlbumName";
            this.label2ndAlbumName.Size = new System.Drawing.Size(0, 13);
            this.label2ndAlbumName.TabIndex = 19;
            // 
            // label1stAlbumName
            // 
            this.label1stAlbumName.AutoSize = true;
            this.label1stAlbumName.Location = new System.Drawing.Point(17, 266);
            this.label1stAlbumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1stAlbumName.Name = "label1stAlbumName";
            this.label1stAlbumName.Size = new System.Drawing.Size(0, 13);
            this.label1stAlbumName.TabIndex = 18;
            // 
            // pictureBox3rdAlbumPicture
            // 
            this.pictureBox3rdAlbumPicture.Location = new System.Drawing.Point(269, 179);
            this.pictureBox3rdAlbumPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3rdAlbumPicture.Name = "pictureBox3rdAlbumPicture";
            this.pictureBox3rdAlbumPicture.Size = new System.Drawing.Size(87, 84);
            this.pictureBox3rdAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3rdAlbumPicture.TabIndex = 9;
            this.pictureBox3rdAlbumPicture.TabStop = false;
            this.pictureBox3rdAlbumPicture.Click += new System.EventHandler(this.pictureBoxTopAlbum_Click);
            // 
            // pictureBox2ndAlbumPicture
            // 
            this.pictureBox2ndAlbumPicture.Location = new System.Drawing.Point(143, 179);
            this.pictureBox2ndAlbumPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2ndAlbumPicture.Name = "pictureBox2ndAlbumPicture";
            this.pictureBox2ndAlbumPicture.Size = new System.Drawing.Size(87, 84);
            this.pictureBox2ndAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2ndAlbumPicture.TabIndex = 9;
            this.pictureBox2ndAlbumPicture.TabStop = false;
            this.pictureBox2ndAlbumPicture.Click += new System.EventHandler(this.pictureBoxTopAlbum_Click);
            // 
            // pictureBox1stAlbumPicture
            // 
            this.pictureBox1stAlbumPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1stAlbumPicture.Location = new System.Drawing.Point(17, 179);
            this.pictureBox1stAlbumPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1stAlbumPicture.Name = "pictureBox1stAlbumPicture";
            this.pictureBox1stAlbumPicture.Size = new System.Drawing.Size(87, 84);
            this.pictureBox1stAlbumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1stAlbumPicture.TabIndex = 9;
            this.pictureBox1stAlbumPicture.TabStop = false;
            this.pictureBox1stAlbumPicture.Click += new System.EventHandler(this.pictureBoxTopAlbum_Click);
            // 
            // radioButtonCreatedDate
            // 
            this.radioButtonCreatedDate.AutoSize = true;
            this.radioButtonCreatedDate.Checked = true;
            this.radioButtonCreatedDate.Location = new System.Drawing.Point(17, 133);
            this.radioButtonCreatedDate.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCreatedDate.Name = "radioButtonCreatedDate";
            this.radioButtonCreatedDate.Size = new System.Drawing.Size(86, 17);
            this.radioButtonCreatedDate.TabIndex = 2;
            this.radioButtonCreatedDate.TabStop = true;
            this.radioButtonCreatedDate.Text = "Created date";
            this.radioButtonCreatedDate.UseVisualStyleBackColor = true;
            this.radioButtonCreatedDate.CheckedChanged += new System.EventHandler(this.radioButtonSortAlbums_CheckedChanged);
            // 
            // radioButtonMostLiked
            // 
            this.radioButtonMostLiked.AutoSize = true;
            this.radioButtonMostLiked.Location = new System.Drawing.Point(105, 133);
            this.radioButtonMostLiked.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMostLiked.Name = "radioButtonMostLiked";
            this.radioButtonMostLiked.Size = new System.Drawing.Size(109, 17);
            this.radioButtonMostLiked.TabIndex = 1;
            this.radioButtonMostLiked.Text = "Most liked albums";
            this.radioButtonMostLiked.UseVisualStyleBackColor = true;
            this.radioButtonMostLiked.CheckedChanged += new System.EventHandler(this.radioButtonSortAlbums_CheckedChanged);
            // 
            // tabBirthdays
            // 
            this.tabBirthdays.BackColor = System.Drawing.Color.White;
            this.tabBirthdays.Controls.Add(this.birthdayListBox);
            this.tabBirthdays.Controls.Add(this.lablePostBirthdayBlessingInstructions);
            this.tabBirthdays.Controls.Add(this.buttonPostBirthdayBlessing);
            this.tabBirthdays.Controls.Add(this.richBoxPostBirthdayBlessing);
            this.tabBirthdays.Controls.Add(this.radioButtonWriteABirthdayPost);
            this.tabBirthdays.Controls.Add(this.radioButtonBirthdayBlessing5);
            this.tabBirthdays.Controls.Add(this.radioButtonBirthdayBlessing4);
            this.tabBirthdays.Controls.Add(this.radioButtonBirrthdayBlessing3);
            this.tabBirthdays.Controls.Add(this.radioButtonBirthdayBlessing2);
            this.tabBirthdays.Controls.Add(this.radioButtonBirthdayBlessing1);
            this.tabBirthdays.Controls.Add(this.fetchBirthdaysAccordingCalenderDay);
            this.tabBirthdays.Controls.Add(this.labelCalenderInstructions);
            this.tabBirthdays.Controls.Add(this.monthCalenderBirthdays);
            this.tabBirthdays.Location = new System.Drawing.Point(4, 22);
            this.tabBirthdays.Margin = new System.Windows.Forms.Padding(2);
            this.tabBirthdays.Name = "tabBirthdays";
            this.tabBirthdays.Padding = new System.Windows.Forms.Padding(2);
            this.tabBirthdays.Size = new System.Drawing.Size(782, 531);
            this.tabBirthdays.TabIndex = 2;
            this.tabBirthdays.Text = "Birthdays";
            this.tabBirthdays.UseVisualStyleBackColor = true;
            // 
            // birthdayListBox
            // 
            this.birthdayListBox.DataSource = this.birthdayUserBindingSource;
            this.birthdayListBox.DisplayMember = "Name";
            this.birthdayListBox.FormattingEnabled = true;
            this.birthdayListBox.Location = new System.Drawing.Point(12, 358);
            this.birthdayListBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthdayListBox.Name = "birthdayListBox";
            this.birthdayListBox.Size = new System.Drawing.Size(208, 160);
            this.birthdayListBox.TabIndex = 60;
            // 
            // birthdayUserBindingSource
            // 
            this.birthdayUserBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // lablePostBirthdayBlessingInstructions
            // 
            this.lablePostBirthdayBlessingInstructions.AutoSize = true;
            this.lablePostBirthdayBlessingInstructions.Location = new System.Drawing.Point(252, 134);
            this.lablePostBirthdayBlessingInstructions.Name = "lablePostBirthdayBlessingInstructions";
            this.lablePostBirthdayBlessingInstructions.Size = new System.Drawing.Size(209, 52);
            this.lablePostBirthdayBlessingInstructions.TabIndex = 59;
            this.lablePostBirthdayBlessingInstructions.Text = "Select a friend who celebrates his birthday \r\nto congratulate him!\r\nHere are some" +
    " possible birthday blessings\r\nyou can post on his wall:";
            // 
            // buttonPostBirthdayBlessing
            // 
            this.buttonPostBirthdayBlessing.Location = new System.Drawing.Point(618, 358);
            this.buttonPostBirthdayBlessing.Name = "buttonPostBirthdayBlessing";
            this.buttonPostBirthdayBlessing.Size = new System.Drawing.Size(139, 46);
            this.buttonPostBirthdayBlessing.TabIndex = 58;
            this.buttonPostBirthdayBlessing.Text = "Post the selected blessing\r\n";
            this.buttonPostBirthdayBlessing.UseVisualStyleBackColor = true;
            this.buttonPostBirthdayBlessing.Click += new System.EventHandler(this.buttonPostBirthdayBlessing_Click);
            // 
            // richBoxPostBirthdayBlessing
            // 
            this.richBoxPostBirthdayBlessing.Location = new System.Drawing.Point(524, 156);
            this.richBoxPostBirthdayBlessing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richBoxPostBirthdayBlessing.Name = "richBoxPostBirthdayBlessing";
            this.richBoxPostBirthdayBlessing.Size = new System.Drawing.Size(234, 193);
            this.richBoxPostBirthdayBlessing.TabIndex = 57;
            this.richBoxPostBirthdayBlessing.Text = "";
            // 
            // radioButtonWriteABirthdayPost
            // 
            this.radioButtonWriteABirthdayPost.AutoSize = true;
            this.radioButtonWriteABirthdayPost.Location = new System.Drawing.Point(524, 134);
            this.radioButtonWriteABirthdayPost.Name = "radioButtonWriteABirthdayPost";
            this.radioButtonWriteABirthdayPost.Size = new System.Drawing.Size(204, 17);
            this.radioButtonWriteABirthdayPost.TabIndex = 32;
            this.radioButtonWriteABirthdayPost.TabStop = true;
            this.radioButtonWriteABirthdayPost.Text = "Write a birthday blessing on your own:\r\n";
            this.radioButtonWriteABirthdayPost.UseVisualStyleBackColor = true;
            // 
            // radioButtonBirthdayBlessing5
            // 
            this.radioButtonBirthdayBlessing5.AutoSize = true;
            this.radioButtonBirthdayBlessing5.Location = new System.Drawing.Point(255, 473);
            this.radioButtonBirthdayBlessing5.Name = "radioButtonBirthdayBlessing5";
            this.radioButtonBirthdayBlessing5.Size = new System.Drawing.Size(267, 43);
            this.radioButtonBirthdayBlessing5.TabIndex = 30;
            this.radioButtonBirthdayBlessing5.TabStop = true;
            this.radioButtonBirthdayBlessing5.Text = "Best wishes for a wonderful birthday full of fun, \r\nlaughter, and all the birthda" +
    "y cake you can handle. \r\nHappy birthday!";
            this.radioButtonBirthdayBlessing5.UseVisualStyleBackColor = true;
            // 
            // radioButtonBirthdayBlessing4
            // 
            this.radioButtonBirthdayBlessing4.AutoSize = true;
            this.radioButtonBirthdayBlessing4.Location = new System.Drawing.Point(255, 421);
            this.radioButtonBirthdayBlessing4.Name = "radioButtonBirthdayBlessing4";
            this.radioButtonBirthdayBlessing4.Size = new System.Drawing.Size(270, 30);
            this.radioButtonBirthdayBlessing4.TabIndex = 29;
            this.radioButtonBirthdayBlessing4.TabStop = true;
            this.radioButtonBirthdayBlessing4.Text = "Sending you my warmest wishes on this special day.\r\n Happy birthday!";
            this.radioButtonBirthdayBlessing4.UseVisualStyleBackColor = true;
            // 
            // radioButtonBirrthdayBlessing3
            // 
            this.radioButtonBirrthdayBlessing3.AutoSize = true;
            this.radioButtonBirrthdayBlessing3.Location = new System.Drawing.Point(255, 348);
            this.radioButtonBirrthdayBlessing3.Name = "radioButtonBirrthdayBlessing3";
            this.radioButtonBirrthdayBlessing3.Size = new System.Drawing.Size(218, 43);
            this.radioButtonBirrthdayBlessing3.TabIndex = 28;
            this.radioButtonBirrthdayBlessing3.TabStop = true;
            this.radioButtonBirrthdayBlessing3.Text = "Happy birthday! \r\nMay this new year bring with it \r\nnew opportunities to live lif" +
    "e to the fullest.";
            this.radioButtonBirrthdayBlessing3.UseVisualStyleBackColor = true;
            // 
            // radioButtonBirthdayBlessing2
            // 
            this.radioButtonBirthdayBlessing2.AutoSize = true;
            this.radioButtonBirthdayBlessing2.Location = new System.Drawing.Point(255, 280);
            this.radioButtonBirthdayBlessing2.Name = "radioButtonBirthdayBlessing2";
            this.radioButtonBirthdayBlessing2.Size = new System.Drawing.Size(177, 43);
            this.radioButtonBirthdayBlessing2.TabIndex = 27;
            this.radioButtonBirthdayBlessing2.TabStop = true;
            this.radioButtonBirthdayBlessing2.Text = "Some things get better with age,\r\nyou\'re one of them!\r\nHappy Birthday my friend! " +
    "";
            this.radioButtonBirthdayBlessing2.UseVisualStyleBackColor = true;
            // 
            // radioButtonBirthdayBlessing1
            // 
            this.radioButtonBirthdayBlessing1.AutoSize = true;
            this.radioButtonBirthdayBlessing1.Checked = true;
            this.radioButtonBirthdayBlessing1.Location = new System.Drawing.Point(255, 210);
            this.radioButtonBirthdayBlessing1.Name = "radioButtonBirthdayBlessing1";
            this.radioButtonBirthdayBlessing1.Size = new System.Drawing.Size(225, 43);
            this.radioButtonBirthdayBlessing1.TabIndex = 26;
            this.radioButtonBirthdayBlessing1.TabStop = true;
            this.radioButtonBirthdayBlessing1.Text = "Wishing you all the happiness in the world,\r\n and a little bit extra for good mea" +
    "sure. \r\nHappy birthday!";
            this.radioButtonBirthdayBlessing1.UseVisualStyleBackColor = true;
            // 
            // fetchBirthdaysAccordingCalenderDay
            // 
            this.fetchBirthdaysAccordingCalenderDay.Location = new System.Drawing.Point(12, 329);
            this.fetchBirthdaysAccordingCalenderDay.Name = "fetchBirthdaysAccordingCalenderDay";
            this.fetchBirthdaysAccordingCalenderDay.Size = new System.Drawing.Size(128, 23);
            this.fetchBirthdaysAccordingCalenderDay.TabIndex = 24;
            this.fetchBirthdaysAccordingCalenderDay.Text = "Fetch celebrators";
            this.fetchBirthdaysAccordingCalenderDay.UseVisualStyleBackColor = true;
            this.fetchBirthdaysAccordingCalenderDay.Click += new System.EventHandler(this.fetchBirthdaysAccordingCalenderDay_Click);
            // 
            // labelCalenderInstructions
            // 
            this.labelCalenderInstructions.AutoSize = true;
            this.labelCalenderInstructions.Location = new System.Drawing.Point(10, 292);
            this.labelCalenderInstructions.Name = "labelCalenderInstructions";
            this.labelCalenderInstructions.Size = new System.Drawing.Size(181, 26);
            this.labelCalenderInstructions.TabIndex = 23;
            this.labelCalenderInstructions.Text = "Select a day in order to see which \r\nfriends celebrate birthday on that day\r\n";
            // 
            // monthCalenderBirthdays
            // 
            this.monthCalenderBirthdays.Location = new System.Drawing.Point(12, 120);
            this.monthCalenderBirthdays.MaxSelectionCount = 1;
            this.monthCalenderBirthdays.Name = "monthCalenderBirthdays";
            this.monthCalenderBirthdays.ShowToday = false;
            this.monthCalenderBirthdays.TabIndex = 0;
            // 
            // tabEvents
            // 
            this.tabEvents.BackColor = System.Drawing.Color.White;
            this.tabEvents.Controls.Add(this.panelMyEventsTab);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Margin = new System.Windows.Forms.Padding(2);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(2);
            this.tabEvents.Size = new System.Drawing.Size(782, 531);
            this.tabEvents.TabIndex = 3;
            this.tabEvents.Text = "Events";
            // 
            // panelMyEventsTab
            // 
            this.panelMyEventsTab.Controls.Add(this.dateTimePicker1);
            this.panelMyEventsTab.Controls.Add(this.listBoxUserEvents);
            this.panelMyEventsTab.Controls.Add(lableMaybeCount);
            this.panelMyEventsTab.Controls.Add(this.lableMaybeCountDetails);
            this.panelMyEventsTab.Controls.Add(lableAttendingCount);
            this.panelMyEventsTab.Controls.Add(this.lableAttendingCountDetails);
            this.panelMyEventsTab.Controls.Add(labelDescription);
            this.panelMyEventsTab.Controls.Add(this.lableEventDescription);
            this.panelMyEventsTab.Controls.Add(labelEndTime);
            this.panelMyEventsTab.Controls.Add(this.startTimeDateTimePicker);
            this.panelMyEventsTab.Controls.Add(this.pictureBoxEvent);
            this.panelMyEventsTab.Controls.Add(lableLocation);
            this.panelMyEventsTab.Controls.Add(this.lableLocationDetails);
            this.panelMyEventsTab.Controls.Add(labelStartTime);
            this.panelMyEventsTab.Controls.Add(this.labelMyEvents);
            this.panelMyEventsTab.Location = new System.Drawing.Point(15, 125);
            this.panelMyEventsTab.Margin = new System.Windows.Forms.Padding(2);
            this.panelMyEventsTab.Name = "panelMyEventsTab";
            this.panelMyEventsTab.Size = new System.Drawing.Size(743, 363);
            this.panelMyEventsTab.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 119);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // listBoxUserEvents
            // 
            this.listBoxUserEvents.DataSource = this.eventBindingSource;
            this.listBoxUserEvents.DisplayMember = "Name";
            this.listBoxUserEvents.FormattingEnabled = true;
            this.listBoxUserEvents.Location = new System.Drawing.Point(20, 82);
            this.listBoxUserEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUserEvents.Name = "listBoxUserEvents";
            this.listBoxUserEvents.Size = new System.Drawing.Size(198, 251);
            this.listBoxUserEvents.TabIndex = 30;
            // 
            // lableMaybeCountDetails
            // 
            this.lableMaybeCountDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "MaybeCount", true));
            this.lableMaybeCountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableMaybeCountDetails.Location = new System.Drawing.Point(326, 259);
            this.lableMaybeCountDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableMaybeCountDetails.Name = "lableMaybeCountDetails";
            this.lableMaybeCountDetails.Size = new System.Drawing.Size(75, 19);
            this.lableMaybeCountDetails.TabIndex = 29;
            // 
            // lableAttendingCountDetails
            // 
            this.lableAttendingCountDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "AttendingCount", true));
            this.lableAttendingCountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableAttendingCountDetails.Location = new System.Drawing.Point(326, 226);
            this.lableAttendingCountDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableAttendingCountDetails.Name = "lableAttendingCountDetails";
            this.lableAttendingCountDetails.Size = new System.Drawing.Size(150, 19);
            this.lableAttendingCountDetails.TabIndex = 16;
            // 
            // lableEventDescription
            // 
            this.lableEventDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.lableEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableEventDescription.Location = new System.Drawing.Point(326, 86);
            this.lableEventDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableEventDescription.Name = "lableEventDescription";
            this.lableEventDescription.Size = new System.Drawing.Size(150, 19);
            this.lableEventDescription.TabIndex = 18;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Enabled = false;
            this.startTimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(326, 156);
            this.startTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(151, 23);
            this.startTimeDateTimePicker.TabIndex = 20;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.pictureBoxEvent.Location = new System.Drawing.Point(507, 86);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(113, 114);
            this.pictureBoxEvent.TabIndex = 22;
            this.pictureBoxEvent.TabStop = false;
            // 
            // lableLocationDetails
            // 
            this.lableLocationDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.lableLocationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableLocationDetails.Location = new System.Drawing.Point(326, 193);
            this.lableLocationDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableLocationDetails.Name = "lableLocationDetails";
            this.lableLocationDetails.Size = new System.Drawing.Size(150, 19);
            this.lableLocationDetails.TabIndex = 24;
            // 
            // labelMyEvents
            // 
            this.labelMyEvents.AutoSize = true;
            this.labelMyEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMyEvents.Location = new System.Drawing.Point(26, 57);
            this.labelMyEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyEvents.Name = "labelMyEvents";
            this.labelMyEvents.Size = new System.Drawing.Size(82, 20);
            this.labelMyEvents.TabIndex = 15;
            this.labelMyEvents.Text = "My Events";
            // 
            // tabLikedPages
            // 
            this.tabLikedPages.AutoScroll = true;
            this.tabLikedPages.BackColor = System.Drawing.Color.White;
            this.tabLikedPages.Controls.Add(this.panelLikedPagesTab);
            this.tabLikedPages.Location = new System.Drawing.Point(4, 22);
            this.tabLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.tabLikedPages.Name = "tabLikedPages";
            this.tabLikedPages.Padding = new System.Windows.Forms.Padding(2);
            this.tabLikedPages.Size = new System.Drawing.Size(782, 531);
            this.tabLikedPages.TabIndex = 4;
            this.tabLikedPages.Text = "Liked pages";
            // 
            // panelLikedPagesTab
            // 
            this.panelLikedPagesTab.Controls.Add(this.listBoxLikedPages);
            this.panelLikedPagesTab.Controls.Add(lableLikedPageDescription);
            this.panelLikedPagesTab.Controls.Add(this.lableLikedPageDescriptionDetails);
            this.panelLikedPagesTab.Controls.Add(lablePageLikesCount);
            this.panelLikedPagesTab.Controls.Add(this.likesCountLabel1);
            this.panelLikedPagesTab.Controls.Add(lablePageCategory);
            this.panelLikedPagesTab.Controls.Add(this.lablePageCategoryDetails);
            this.panelLikedPagesTab.Controls.Add(this.PictureBoxPageProfile);
            this.panelLikedPagesTab.Controls.Add(this.labelLikedPagesTab);
            this.panelLikedPagesTab.Location = new System.Drawing.Point(8, 114);
            this.panelLikedPagesTab.Margin = new System.Windows.Forms.Padding(2);
            this.panelLikedPagesTab.Name = "panelLikedPagesTab";
            this.panelLikedPagesTab.Size = new System.Drawing.Size(769, 423);
            this.panelLikedPagesTab.TabIndex = 0;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(10, 46);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(335, 303);
            this.listBoxLikedPages.TabIndex = 18;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // lableLikedPageDescriptionDetails
            // 
            this.lableLikedPageDescriptionDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.lableLikedPageDescriptionDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableLikedPageDescriptionDetails.Location = new System.Drawing.Point(515, 247);
            this.lableLikedPageDescriptionDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableLikedPageDescriptionDetails.Name = "lableLikedPageDescriptionDetails";
            this.lableLikedPageDescriptionDetails.Size = new System.Drawing.Size(161, 89);
            this.lableLikedPageDescriptionDetails.TabIndex = 15;
            // 
            // likesCountLabel1
            // 
            this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likesCountLabel1.Location = new System.Drawing.Point(515, 215);
            this.likesCountLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.likesCountLabel1.Name = "likesCountLabel1";
            this.likesCountLabel1.Size = new System.Drawing.Size(75, 19);
            this.likesCountLabel1.TabIndex = 14;
            // 
            // lablePageCategoryDetails
            // 
            this.lablePageCategoryDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Category", true));
            this.lablePageCategoryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lablePageCategoryDetails.Location = new System.Drawing.Point(515, 181);
            this.lablePageCategoryDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lablePageCategoryDetails.Name = "lablePageCategoryDetails";
            this.lablePageCategoryDetails.Size = new System.Drawing.Size(75, 19);
            this.lablePageCategoryDetails.TabIndex = 13;
            // 
            // PictureBoxPageProfile
            // 
            this.PictureBoxPageProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.PictureBoxPageProfile.Location = new System.Drawing.Point(405, 43);
            this.PictureBoxPageProfile.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxPageProfile.Name = "PictureBoxPageProfile";
            this.PictureBoxPageProfile.Size = new System.Drawing.Size(124, 119);
            this.PictureBoxPageProfile.TabIndex = 8;
            this.PictureBoxPageProfile.TabStop = false;
            // 
            // labelLikedPagesTab
            // 
            this.labelLikedPagesTab.AutoSize = true;
            this.labelLikedPagesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikedPagesTab.Location = new System.Drawing.Point(15, 23);
            this.labelLikedPagesTab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLikedPagesTab.Name = "labelLikedPagesTab";
            this.labelLikedPagesTab.Size = new System.Drawing.Size(86, 17);
            this.labelLikedPagesTab.TabIndex = 2;
            this.labelLikedPagesTab.Text = "Liked Pages";
            // 
            // tabAboutMe
            // 
            this.tabAboutMe.BackColor = System.Drawing.Color.White;
            this.tabAboutMe.Controls.Add(this.panelAboutMe);
            this.tabAboutMe.Controls.Add(this.lableAboutMe);
            this.tabAboutMe.Location = new System.Drawing.Point(4, 22);
            this.tabAboutMe.Name = "tabAboutMe";
            this.tabAboutMe.Padding = new System.Windows.Forms.Padding(3);
            this.tabAboutMe.Size = new System.Drawing.Size(782, 531);
            this.tabAboutMe.TabIndex = 5;
            this.tabAboutMe.Text = "About Me";
            // 
            // panelAboutMe
            // 
            this.panelAboutMe.Controls.Add(this.labelRelationshipStatus);
            this.panelAboutMe.Controls.Add(this.labelRelationshipStatusTitle);
            this.panelAboutMe.Controls.Add(this.labelGender);
            this.panelAboutMe.Controls.Add(this.labelGenderTitle);
            this.panelAboutMe.Controls.Add(this.labelBirthday);
            this.panelAboutMe.Controls.Add(this.labelBirthdayTitle);
            this.panelAboutMe.Controls.Add(this.labelEmail);
            this.panelAboutMe.Controls.Add(this.labelEmailTitle);
            this.panelAboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panelAboutMe.Location = new System.Drawing.Point(60, 188);
            this.panelAboutMe.Margin = new System.Windows.Forms.Padding(2);
            this.panelAboutMe.Name = "panelAboutMe";
            this.panelAboutMe.Size = new System.Drawing.Size(638, 242);
            this.panelAboutMe.TabIndex = 83;
            // 
            // labelRelationshipStatus
            // 
            this.labelRelationshipStatus.AutoSize = true;
            this.labelRelationshipStatus.Location = new System.Drawing.Point(185, 173);
            this.labelRelationshipStatus.Name = "labelRelationshipStatus";
            this.labelRelationshipStatus.Size = new System.Drawing.Size(0, 18);
            this.labelRelationshipStatus.TabIndex = 0;
            // 
            // labelRelationshipStatusTitle
            // 
            this.labelRelationshipStatusTitle.AutoSize = true;
            this.labelRelationshipStatusTitle.Location = new System.Drawing.Point(33, 173);
            this.labelRelationshipStatusTitle.Name = "labelRelationshipStatusTitle";
            this.labelRelationshipStatusTitle.Size = new System.Drawing.Size(139, 18);
            this.labelRelationshipStatusTitle.TabIndex = 0;
            this.labelRelationshipStatusTitle.Text = "Relationship Status:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(185, 128);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 18);
            this.labelGender.TabIndex = 0;
            // 
            // labelGenderTitle
            // 
            this.labelGenderTitle.AutoSize = true;
            this.labelGenderTitle.Location = new System.Drawing.Point(33, 128);
            this.labelGenderTitle.Name = "labelGenderTitle";
            this.labelGenderTitle.Size = new System.Drawing.Size(61, 18);
            this.labelGenderTitle.TabIndex = 0;
            this.labelGenderTitle.Text = "Gender:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(185, 83);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(0, 18);
            this.labelBirthday.TabIndex = 0;
            // 
            // labelBirthdayTitle
            // 
            this.labelBirthdayTitle.AutoSize = true;
            this.labelBirthdayTitle.Location = new System.Drawing.Point(33, 83);
            this.labelBirthdayTitle.Name = "labelBirthdayTitle";
            this.labelBirthdayTitle.Size = new System.Drawing.Size(65, 18);
            this.labelBirthdayTitle.TabIndex = 0;
            this.labelBirthdayTitle.Text = "Birthday:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(185, 38);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 18);
            this.labelEmail.TabIndex = 0;
            // 
            // labelEmailTitle
            // 
            this.labelEmailTitle.AutoSize = true;
            this.labelEmailTitle.Location = new System.Drawing.Point(33, 38);
            this.labelEmailTitle.Name = "labelEmailTitle";
            this.labelEmailTitle.Size = new System.Drawing.Size(49, 18);
            this.labelEmailTitle.TabIndex = 0;
            this.labelEmailTitle.Text = "Email:";
            // 
            // lableAboutMe
            // 
            this.lableAboutMe.AutoSize = true;
            this.lableAboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableAboutMe.Location = new System.Drawing.Point(59, 152);
            this.lableAboutMe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lableAboutMe.Name = "lableAboutMe";
            this.lableAboutMe.Size = new System.Drawing.Size(92, 24);
            this.lableAboutMe.TabIndex = 82;
            this.lableAboutMe.Text = "About Me";
            // 
            // labelHelloUser
            // 
            this.labelHelloUser.AutoSize = true;
            this.labelHelloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelloUser.Location = new System.Drawing.Point(588, 36);
            this.labelHelloUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelloUser.Name = "labelHelloUser";
            this.labelHelloUser.Size = new System.Drawing.Size(0, 17);
            this.labelHelloUser.TabIndex = 69;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(37, 7);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(93, 91);
            this.pictureBoxProfilePicture.TabIndex = 54;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(585, 69);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(77, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxFacebookLogo
            // 
            this.pictureBoxFacebookLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxFacebookLogo.Image = global::FacebookUI.Properties.Resources.facebookMain;
            this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(173, 21);
            this.pictureBoxFacebookLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(398, 76);
            this.pictureBoxFacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFacebookLogo.TabIndex = 53;
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.pictureBoxFacebookLogo);
            this.panelHeader.Controls.Add(this.buttonLogout);
            this.panelHeader.Controls.Add(this.pictureBoxProfilePicture);
            this.panelHeader.Controls.Add(this.labelHelloUser);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelHeader.Location = new System.Drawing.Point(15, 40);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(769, 100);
            this.panelHeader.TabIndex = 69;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bindingSourceAboutMe
            // 
            this.bindingSourceAboutMe.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(805, 570);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFacebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.todayCelebratorsUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thisWeekEventBindingSource)).EndInit();
            this.TabAlbums.ResumeLayout(false);
            this.TabAlbums.PerformLayout();
            this.panelSelectedAlbumPhotos.ResumeLayout(false);
            this.panelSelectedAlbumPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbumCurrentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSelectedAlbumPhotos)).EndInit();
            this.bindingNavigatorSelectedAlbumPhotos.ResumeLayout(false);
            this.bindingNavigatorSelectedAlbumPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3rdAlbumPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2ndAlbumPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1stAlbumPicture)).EndInit();
            this.tabBirthdays.ResumeLayout(false);
            this.tabBirthdays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayUserBindingSource)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.panelMyEventsTab.ResumeLayout(false);
            this.panelMyEventsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.tabLikedPages.ResumeLayout(false);
            this.panelLikedPagesTab.ResumeLayout(false);
            this.panelLikedPagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPageProfile)).EndInit();
            this.tabAboutMe.ResumeLayout(false);
            this.tabAboutMe.PerformLayout();
            this.panelAboutMe.ResumeLayout(false);
            this.panelAboutMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAboutMe)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.RichTextBox richTextBoxNewStatus;
        private System.Windows.Forms.Button buttonPostNewStatus;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage TabAlbums;
        private System.Windows.Forms.RadioButton radioButtonCreatedDate;
        private System.Windows.Forms.RadioButton radioButtonMostLiked;
        private System.Windows.Forms.PictureBox pictureBox1stAlbumPicture;
        private System.Windows.Forms.Label label3rdAlbumName;
        private System.Windows.Forms.Label label2ndAlbumName;
        private System.Windows.Forms.Label label1stAlbumName;
        private System.Windows.Forms.Label labelBirthdays;
        private System.Windows.Forms.Label labeThisWeekEvents;
        private System.Windows.Forms.Label labelMyFriends;
        private System.Windows.Forms.Label labelOrderAlbumsBy;
        private System.Windows.Forms.PictureBox pictureBox3rdAlbumPicture;
        private System.Windows.Forms.PictureBox pictureBox2ndAlbumPicture;
        private System.Windows.Forms.RadioButton radioButtonLastUpdate;
        private System.Windows.Forms.TabPage tabBirthdays;
        private System.Windows.Forms.Button fetchBirthdaysAccordingCalenderDay;
        private System.Windows.Forms.Label labelCalenderInstructions;
        private System.Windows.Forms.MonthCalendar monthCalenderBirthdays;
        private System.Windows.Forms.RichTextBox richBoxPostBirthdayBlessing;
        private System.Windows.Forms.RadioButton radioButtonWriteABirthdayPost;
        private System.Windows.Forms.RadioButton radioButtonBirthdayBlessing5;
        private System.Windows.Forms.RadioButton radioButtonBirthdayBlessing4;
        private System.Windows.Forms.RadioButton radioButtonBirrthdayBlessing3;
        private System.Windows.Forms.RadioButton radioButtonBirthdayBlessing2;
        private System.Windows.Forms.RadioButton radioButtonBirthdayBlessing1;
        private System.Windows.Forms.Button buttonPostBirthdayBlessing;
        private System.Windows.Forms.Label lablePostBirthdayBlessingInstructions;
        private System.Windows.Forms.Label labelHelloUser;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource birthdayUserBindingSource;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.Panel panelMyEventsTab;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label labelAlbumsInstruction;
        private System.Windows.Forms.Label lableMaybeCountDetails;
        private System.Windows.Forms.Label lableAttendingCountDetails;
        private System.Windows.Forms.Label lableEventDescription;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Label lableLocationDetails;
        private System.Windows.Forms.Label labelMyEvents;
        private System.Windows.Forms.TabPage tabLikedPages;
        private System.Windows.Forms.Panel panelLikedPagesTab;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Label labelLikedPagesTab;
        private System.Windows.Forms.Label lableLikedPageDescriptionDetails;
        private System.Windows.Forms.Label likesCountLabel1;
        private System.Windows.Forms.Label lablePageCategoryDetails;
        private System.Windows.Forms.PictureBox PictureBoxPageProfile;
        private System.Windows.Forms.BindingSource todayCelebratorsUsersBindingSource;
        private System.Windows.Forms.BindingSource friendBindingSource;
        private MyListBox listBoxFriendsList;
        private MyListBox listBoxPosts;
        private MyListBox listBoxTodayBirthdays;
        private MyListBox listBoxUpcomingEventsThisWeek;
        private MyListBox listBoxAlbums;
        private MyListBox birthdayListBox;
        private MyListBox listBoxUserEvents;
        private MyListBox listBoxLikedPages;
        private System.Windows.Forms.BindingSource thisWeekEventBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceAboutMe;
        private System.Windows.Forms.Panel panelSelectedAlbumPhotos;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSelectedAlbumPhotos;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.PictureBox pictureBoxSelectedAlbumCurrentPhoto;
        private System.Windows.Forms.TabPage tabAboutMe;
        private System.Windows.Forms.Panel panelAboutMe;
        private System.Windows.Forms.Label labelRelationshipStatus;
        private System.Windows.Forms.Label labelRelationshipStatusTitle;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelGenderTitle;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelBirthdayTitle;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEmailTitle;
        private System.Windows.Forms.Label lableAboutMe;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

