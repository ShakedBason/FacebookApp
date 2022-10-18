using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace FacebookLogic
{
    public class UpdateTimeSortAlbumsStrategy : IAlbumsSortStrategy
    {
        public List<Album> Sort(List<Album> i_AlbumListToSort)
        {
            return i_AlbumListToSort.OrderByDescending(album => album.UpdateTime).ToList();
        }
    }
}
