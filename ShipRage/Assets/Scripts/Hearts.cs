using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public Sprite fullHeart, halfHeart, emptyHeart;
    private Image img;

    private void Awake()
    {
        img = GetComponent<Image>();
    }

    public void SetHeartImage(HeartStatus status)
    {
        switch(status)
        {
            case HeartStatus.Empty:
                img.sprite = emptyHeart;
                break;

            case HeartStatus.Half:
                img.sprite = halfHeart;
                break;

            case HeartStatus.Full:
                img.sprite = fullHeart;
                break;
        }
    }

    public enum HeartStatus
    {
        Empty = 1,
        Half = 2,
        Full = 3
    }
}
