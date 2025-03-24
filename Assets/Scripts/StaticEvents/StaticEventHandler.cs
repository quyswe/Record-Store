using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.XR.ARFoundation;

public static class StaticEventHandler
{

    public static event Action<SongDescription, PhysicalCDAlbum> OnSongChanged;

    public static void InvokeSongChanged(SongDescription songDescription, PhysicalCDAlbum physicalCDAlbum)
    {
        OnSongChanged?.Invoke(songDescription, physicalCDAlbum);
    }
    public static event Action<AlbumSO, PhysicalCDAlbum> OnStartFirstSong;

    public static void InvokeStartFirstSong(AlbumSO album, PhysicalCDAlbum physicalCDAlbum)
    {
        OnStartFirstSong?.Invoke(album, physicalCDAlbum);
    }


}
