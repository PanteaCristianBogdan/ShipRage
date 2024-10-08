using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Pause_Menu_Scripts : MonoBehaviour
{
    public int canPause;
    public GameObject menuPause;
    public GameObject fps;

    public bool dead;

    public GameObject Sesion_Selectors_Prefab;
    [HideInInspector]
    public GameObject Sesion_Selectors;
    public Transform Background_Sesion;
    [HideInInspector]
    public GameObject ShipSelector;
    [HideInInspector]
    public GameObject NameInputField;

    private int p = 1;
    public int deadPlayer;

    public string nameP1;
    public GameObject shipP1Prefab;
    public GameObject shipP1;
    public GameObject shipP1Smoke;
    public GameObject P1StartPoint;
    public GameObject P1ExplosionPoint;
    public Vector3 P1StartPointCoordinates;


    public string nameP2;
    public GameObject shipP2Prefab;
    public GameObject shipP2;
    public GameObject shipP2Smoke;
    public GameObject P2StartPoint;
    public GameObject P2ExplosionPoint;
    public Vector3 P2StartPointCoordinates;

    public GameObject explosion_Prefab;
    public GameObject explosion;

    public GameObject bulletExplosion_Prefab;
    
    public GameObject rocketExplosion_Prefab;

    public GameObject wonText;
    public GameObject timmerText;

    public int killsP1;
    public GameObject killsP1_Text;
    public int killsP2;
    public GameObject killsP2_Text;

    public GameObject readyButton, startButton;

    private static Pause_Menu_Scripts instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        Sesion_Selectors = Instantiate(Sesion_Selectors_Prefab, Background_Sesion, false);
        ShipSelector = GameObject.FindGameObjectWithTag("ShipSelector");
        NameInputField = GameObject.FindGameObjectWithTag("InputField");

        P1StartPointCoordinates = P1StartPoint.transform.position;
        P2StartPointCoordinates = P2StartPoint.transform.position;

        dead = false;
    }

    public static Pause_Menu_Scripts MyInstance
    {
        get
        {
            return instance;
        }
    }

    public bool IsPaused
    {
        get
        {
            if (canPause == 1 || canPause == -2)
                return false;
            else
                return true;
        }
    }

    public bool IsDead
    {
        get
        {
            return dead;
        }
    }

    private void Start()
    {
        StopGame();

        killsP1 = 0;
        killsP2 = 0;
    }

    public void Won(int player)
    {
        wonText.SetActive(true);
        canPause = -2;
        deadPlayer = player;

        if (player == 1)
        {
            if (nameP2 == "")
                wonText.GetComponent<TMP_Text>().text = "Player2 won!";
            else
                wonText.GetComponent<TMP_Text>().text = nameP2 + " won!";
        }
        else if (player == 2)
        {
            if (nameP1 == "")
                wonText.GetComponent<TMP_Text>().text = "Player1 won!";
            else
                wonText.GetComponent<TMP_Text>().text = nameP1 + " won!";
        }

        Timmer(0);
    }

    public void RestartTheBattle()
    {
        P1StartPoint.GetComponent<Rigidbody>().velocity = Vector3.zero;
        P2StartPoint.GetComponent<Rigidbody>().velocity = Vector3.zero;

        P1StartPoint.transform.position = P1StartPointCoordinates;
        P2StartPoint.transform.position = P2StartPointCoordinates;

        HeartsDisplay.MyInstance.p1Stat.ResetHealth();
        HeartsDisplay.MyInstance.p2Stat.ResetHealth();

        shipP1Smoke.SetActive(true);
        shipP2Smoke.SetActive(true);

        P1StartPoint.GetComponent<Ship_Shooting>().ResetAmmo();
        P2StartPoint.GetComponent<Ship_Shooting>().ResetAmmo();

        Destroy(explosion);
    }

    public void SmokeDeactivate(int p)
    {
        if (p == 1)
            shipP1Smoke.SetActive(false);
        else if (p == 2)
            shipP2Smoke.SetActive(false);
    }

    public void ExplosionInitialisation(int p)
    {
        if (p == 1)
            explosion = Instantiate(explosion_Prefab, P1ExplosionPoint.transform);
        else if (p == 2)
            explosion = Instantiate(explosion_Prefab, P2ExplosionPoint.transform);
    }

    public void Timmer(int var)
    {
        gameObject.AddComponent<Timmer>();
        gameObject.GetComponent<Timmer>().timmerText = timmerText;
        gameObject.GetComponent<Timmer>().var = var;
    }

    public void KillsUpdate(int p)
    {
        if (p == 1)
        {
            killsP2++;
            killsP2_Text.GetComponent<TMP_Text>().text = killsP2.ToString();
        }
        else if (p == 2)
        {
            killsP1++;
            killsP1_Text.GetComponent<TMP_Text>().text = killsP1.ToString();
        }
    }

    public void SHIPSelector (bool activeBool)
    {
        ShipSelector.GetComponent<CanvasGroup>().interactable = activeBool;
    }

    public void SesionSelectorRemover()
    {
        Destroy(Sesion_Selectors);
    }

    public void ButtonsInteractable()
    {
        readyButton.GetComponent<Button>().interactable = !readyButton.GetComponent<Button>().interactable;
        startButton.GetComponent<Button>().interactable = !startButton.GetComponent<Button>().interactable;
    }

    public void GetShip(GameObject shipPrefab)
    {
        if (p == 1)
        {
            shipP1Prefab = shipPrefab;
            shipP1 = Instantiate(shipP1Prefab, P1StartPoint.transform, false);
        }
        else if (p == 2)
        {
            shipP2Prefab = shipPrefab;
            shipP2 = Instantiate(shipP2Prefab, P2StartPoint.transform, false);
        }
    }

    public void RestartNameInputFieldP1()
    {
        if (NameInputField.GetComponent<TMP_InputField>().text == "Enter Name")
            nameP1 = "";
        else
        {
            nameP1 = NameInputField.GetComponent<TMP_InputField>().text;
            NameInputField.GetComponent<TMP_InputField>().text = "Enter Name";
        }

        p = 2;
    }

    public void RestartNameInputFieldP2()
    {
        if (NameInputField.GetComponent<TMP_InputField>().text == "Enter Name")
            nameP2 = "";
        else
            nameP2 = NameInputField.GetComponent<TMP_InputField>().text;

        p = 1;
    }

    public void StopGame()
    {
        canPause = -1;
        Time.timeScale = 0f;
    }

    public void UnStopGame()
    {
        Time.timeScale = 1f;
        fps.SetActive(UIManager.MyInstance.fps);
        canPause = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void PlayButtonSound(string name)
    {
        Audio_Manager.MyInstance.Play(name);
    }

    public void PauseGame()
    {
        canPause = 0;
        menuPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        canPause = 1;
        menuPause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canPause == 1)
                PauseGame();
            else if (canPause == 0)
                ResumeGame();
        }
    }
}
