using TMPro;
using UnityEngine;

public class Timmer : MonoBehaviour
{
    public GameObject timmerText;
    public int var;
    public float timmer = 3.99f;
    public float secondTimmer = 1;
    public float thirdTimmer = 2;

    private void Start()
    {
        timmerText.SetActive(true);
        timmerText.GetComponent<TMP_Text>().text = "";

        if (var == 1)
        {
            Pause_Menu_Scripts.MyInstance.canPause = -1;
            thirdTimmer = 0;
        }
    }

    void Update()
    {
        if (thirdTimmer > 0)
        {
            thirdTimmer -= Time.unscaledDeltaTime;

            DisableWonText();
        }
        else
        {
            if (timmer > 1)
            {
                timmer -= Time.unscaledDeltaTime;
                DisplayTime(timmer);
            }
            else if (timmer <= 1)
            {
                timmerText.GetComponent<TMP_Text>().text = "Fight";

                if (secondTimmer > 0)
                {
                    secondTimmer -= Time.unscaledDeltaTime;
                }
                else
                {
                    timmerText.GetComponent<TMP_Text>().text = "";
                    timmerText.SetActive(false);

                    Pause_Menu_Scripts.MyInstance.canPause = 1;
                    Time.timeScale = 1f;
                    Destroy(this);
                }
            }
        }
    }

    public void DisplayTime(float timeToDisplay)
    {
        if (timmer <= 0)
            timmer = 0;

        if (timmer != 0)
        {
            timeToDisplay = (int)timeToDisplay;
            timmerText.GetComponent<TMP_Text>().text = timeToDisplay.ToString();
        }
    }

    public void DisableWonText()
    {
        if (thirdTimmer <= 0)
        {
            Pause_Menu_Scripts.MyInstance.wonText.SetActive(false);
            Keybindings_Manager.MyInstance.SetKeybindingsIfDead(Pause_Menu_Scripts.MyInstance.deadPlayer);
            Pause_Menu_Scripts.MyInstance.dead = false;
            Pause_Menu_Scripts.MyInstance.RestartTheBattle();
            Pause_Menu_Scripts.MyInstance.canPause = -1;
        }
    }
}