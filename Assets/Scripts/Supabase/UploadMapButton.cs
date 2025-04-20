using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UploadMapButton : MonoBehaviour
{
    private Button updateButton;
    private TextMeshProUGUI updateText;
    private void Awake()
    {
        updateButton = GetComponent<Button>();
        updateText = GetComponentInChildren<TextMeshProUGUI>();
        updateButton.onClick.AddListener(OnUpdateButtonClick);
    }
    private void OnDestroy()
    {
        updateButton.onClick.RemoveListener(OnUpdateButtonClick);
    }
    private void OnUpdateButtonClick()
    {
        SupabaseStorage.Instance.UploadSaveFile().ContinueWith(task =>
         {
             if (task.IsFaulted)
             {
                 updateText.text = "Upload failed. Please try again.";
             }
             else
             {
                 updateText.text = "Upload completed successfully.";
             }
         });
    }
}
