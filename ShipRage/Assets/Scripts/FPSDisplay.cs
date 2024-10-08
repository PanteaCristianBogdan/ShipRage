using UnityEngine;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    public TextMeshProUGUI fpsText;

    private readonly float pollingTime = 0.5f;
    private float time = 0;
    private int frameCount = 0;

    private void Awake()
    {
        Application.targetFrameRate = -1; //-1 (fps unlimited)
    }

    void Update()
    {
        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            fpsText.text = frameRate.ToString() + " FPS";

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
