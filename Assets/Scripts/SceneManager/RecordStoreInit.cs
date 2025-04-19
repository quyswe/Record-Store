using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RecordStoreInit : MonoBehaviour
{
    private Button[] buttons;

    private void Awake()
    {
        buttons = GetComponentsInChildren<Button>();

    }

    void NavigateCreateStoreScene()
    {
        UnloadInitScene();
    }
    void NavigateLoadStoreScene()
    {
    }
    void UnloadInitScene()
    {
        SceneManager.UnloadSceneAsync("RecordStoreInit");
    }
}
