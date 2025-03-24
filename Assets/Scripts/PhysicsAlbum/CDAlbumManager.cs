using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class CDAlbumManager : MonoBehaviour
{
    [HideInInspector] public ARTrackedImage aRTrackedImage;
    [SerializeField] private Image artistImage;
    [SerializeField] private TextMeshProUGUI artistName;
    [SerializeField] private TextMeshProUGUI albumName;
    [SerializeField] private TextMeshProUGUI genres;
    [HideInInspector] public AlbumSO albumSO;

    private void Start()
    {
        SelectAlbum(aRTrackedImage);
    }

    private async void SelectAlbum(ARTrackedImage aRTrackedImage)
    {
        switch (aRTrackedImage.referenceImage.name)
        {
            case "Gieo":
                albumSO = GameManager.Instance.albumSOs[0];
                //wait for subcriber to be ready to receive the event
                await Awaitable.WaitForSecondsAsync(2.5f);
                StaticEventHandler.InvokeStartFirstSong(albumSO, PhysicalCDAlbum.Gieo);
                break;
            case "SDDBP":
                albumSO = GameManager.Instance.albumSOs[1];
                await Awaitable.WaitForSecondsAsync(2.5f);
                StaticEventHandler.InvokeStartFirstSong(albumSO, PhysicalCDAlbum.SDDBP);
                break;
        }
        SetAlbumInfo();
    }
    void SetAlbumInfo()
    {
        artistImage.sprite = albumSO.artistImage;
        artistName.text = "Artist: " + albumSO.artistName;
        albumName.text = "Album: " + albumSO.albumName;
        genres.text = "Genres: " + albumSO.genres;
    }
}


