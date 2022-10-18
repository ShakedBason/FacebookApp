using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookLogic
{
    interface IAlbumsSortStrategy
    {
        List<Album> Sort(List<Album> i_AlbumListToSort);
    }
}
