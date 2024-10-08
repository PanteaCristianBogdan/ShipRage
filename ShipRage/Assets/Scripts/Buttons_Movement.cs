using UnityEngine;
using UnityEngine.UI;

public class Buttons_Movement : MonoBehaviour
{
    public int offsetY;
    public RectTransform textRect;
    Vector3 pos;

    Image img;

    [SerializeField]
    Color black, white, newColor;

    void Start()
    {
        black = new Color(200f / 255, 200f / 255, 200f / 255);
        white = new Color(255f / 255, 255f / 255, 255f / 255);

        img = GetComponent<Image>();

        if (textRect)
            pos = textRect.localPosition;
    }

    public void Down()
    {
        if (GetComponent<Button>().interactable)
            textRect.localPosition = new Vector3(pos.x, pos.y - (float)offsetY, pos.z);
    }

    public void Up()
    {
        if (GetComponent<Button>().interactable)
            textRect.localPosition = pos;
    }

    public void ColorBlack()
    {
        if (GetComponent<Button>().interactable)
            img.color = black;
    }
    
    public void ColorWhite()
    {
        if (GetComponent<Button>().interactable)
            img.color = white;
    }

    public void ColorNewColor()
    {
        if (GetComponent<Button>().interactable)
            img.color = newColor;
    }

    public void ChangeWhiteToNewColor()
    {
        if (GetComponent<Button>().interactable)
            white = newColor;
    }

    public void JustForBGSesion()
    {
        img.color = newColor;
    }

}
