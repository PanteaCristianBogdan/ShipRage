using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu_Script : MonoBehaviour
{
    private static Main_Menu_Script instance;

    public Slider slider;
    public Toggle toggle;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public static Main_Menu_Script MyInstance
    {
        get
        {
            return instance;
        }
    }

    private void Start()
    {
        slider.GetComponent<Slider>().value = Audio_Manager.MyInstance.mainVolume;
        UIManager.MyInstance.FindKeybindings();
        UIManager.MyInstance.UpdateKeybindingsButtonsText();
        toggle.isOn = UIManager.MyInstance.fps;
    }

    public void FPS()
    {
        UIManager.MyInstance.FPS();
    }

    public void OnValueChanged()
    {
        Audio_Manager.MyInstance.OnValueChanged();
    }

    public void PlayButtonSound(string name)
    {
        Audio_Manager.MyInstance.Play(name);
    }

    public void SetKeyButton(string name)
    {
        UIManager.MyInstance.SetKeyButton(name);
    }

    public void Play()
    {
        SceneManager.LoadScene("TheMap");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
