﻿namespace Dopamine.Data
{
    public enum AddFolderResult
    {
        Error = 0,
        Success = 1,
        Duplicate = 2,
        Inaccessible = 3
    }

    public enum RemoveFolderResult
    {
        Error = 0,
        Success = 1
    }

    public enum ArtistOrder
    {
        All = 0,
        Track = 1,
        Album = 2
    }

    public enum GenreOrder
    {
        Alphabetical = 1,
        ReverseAlphabetical = 2
    }

    public enum TrackOrder
    {
        Alphabetical = 1,
        ByAlbum = 2,
        ByFileName = 3,
        ByRating = 4,
        ReverseAlphabetical = 5,
        None = 6
    }

    public enum AlbumOrder
    {
        Alphabetical = 1,
        ByDateAdded = 2,
        ByDateCreated = 3,
        ByAlbumArtist = 4,
        ByYear = 5
    }

    public enum RemoveTracksResult
    {
        Error = 0,
        Success = 1
    }
}
