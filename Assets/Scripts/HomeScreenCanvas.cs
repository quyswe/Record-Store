using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenCanvas : MonoBehaviour
{

    [SerializeField] private Canvas mapCanvas;
    [SerializeField] private Image vinylIcon;
    public TextMeshProUGUI uiText;

    public Material textMat;
    public Color colorA = Color.red;
    public Color colorB = Color.blue;
    public float speed = 0.5f;

    private float basePower = 0f;
    private float amplitude = 1f;


    private void Update()
    {
        if (vinylIcon != null)
        {
            vinylIcon.transform.Rotate(0f, 0f, 50f * Time.deltaTime);
        }

        float t = (Mathf.Sin(Time.time * speed) + 1f) / 2f;
        uiText.color = Color.Lerp(colorA, colorB, t);

        float glowPower = basePower + Mathf.PingPong(Time.time * speed, amplitude);
        textMat.SetFloat("_GlowPower", glowPower);
    }

    public void OnMapButtonClicked()
    {
        if (mapCanvas == null)
        {
            Debug.LogError("Map Canvas is not assigned.");
            return;
        }
        mapCanvas.enabled = true;
        gameObject.SetActive(false);
    }
    public void LoadInstructionsScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InstructionScene");
    }
}
