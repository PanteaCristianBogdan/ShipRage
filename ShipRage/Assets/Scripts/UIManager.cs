using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static string changeKeyName = string.Empty;

    private static UIManager instance;

    public GameObject[] keybindings;
    private GameObject setbutGO;

    public bool fps = false;

    public static UIManager MyInstance
    {
        get
        {
            return instance;
        }
    }

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

    public void FindKeybindings()
    {
        keybindings = GameObject.FindGameObjectsWithTag("Keybindings");
    }

    public void UpdateKeybindingsButtonsText()
    {
        foreach (GameObject key in keybindings)
        {
            TextMeshProUGUI t = key.GetComponentInChildren<TextMeshProUGUI>();
            t.text = Keybindings_Manager.MyInstance.ReturnKey(key.name).ToString();
        }
    }

    public void SetKeyButton(string name)
    {
        changeKeyName = name;
        Keybindings_Manager.MyInstance.SetKey(changeKeyName, KeyCode.None);
        SetKeybindingsButtonsText(changeKeyName, KeyCode.None);

        if (setbutGO.name.Contains("1"))
            setbutGO.GetComponent<Image>().color = new Color(192f / 255, 129f / 255, 32f / 255);
        else if (setbutGO.name.Contains("2"))
            setbutGO.GetComponent<Image>().color = new Color(23f / 255, 87f / 255, 171f / 255);
    }

    public void SetKeybindingsButtonsText(string myKey, KeyCode keycode)
    {
        foreach (GameObject key in keybindings)
        {
            if (key.name == myKey)
            {
                TextMeshProUGUI t = key.GetComponentInChildren<TextMeshProUGUI>();
                t.text = keycode.ToString();

                if (keycode == KeyCode.None)
                    setbutGO = key;
            }
        }
    }

    public void FPS()
    {
        fps = Main_Menu_Script.MyInstance.toggle.isOn;
    }

    private void OnGUI()
    {
        if (changeKeyName != string.Empty)
        {
            Event e = Event.current;

            if (e.isKey && e.keyCode != KeyCode.Escape)
            {
                Keybindings_Manager.MyInstance.SetKey(changeKeyName, e.keyCode);

                changeKeyName = string.Empty;

                if (setbutGO.name.Contains("1"))
                    setbutGO.GetComponent<Image>().color = new Color(254f / 255, 166f / 255, 30f / 255);
                else if (setbutGO.name.Contains("2"))
                    setbutGO.GetComponent<Image>().color = new Color(37f / 255, 122f / 255, 233f / 255);
            }
            else if (e.isKey && e.keyCode == KeyCode.Escape)
            {
                changeKeyName = string.Empty;

                if (setbutGO.name.Contains("1"))
                    setbutGO.GetComponent<Image>().color = new Color(254f / 255, 166f / 255, 30f / 255);
                else if (setbutGO.name.Contains("2"))
                    setbutGO.GetComponent<Image>().color = new Color(37f / 255, 122f / 255, 233f / 255);
            }
        }
    }
}
