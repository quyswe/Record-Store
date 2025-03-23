using TMPro;
using UnityEngine;

public class LogPositionCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    private TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Position:\nX: {target.position.x:F2} Y: {target.position.y:F2} Z: {target.position.z:F2}\n" +
           $"Rotation:\nX: {target.rotation.eulerAngles.x:F2} Y: {target.rotation.eulerAngles.y:F2} Z: {target.rotation.eulerAngles.z:F2}\n";

    }
}
