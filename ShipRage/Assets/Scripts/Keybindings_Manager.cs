using UnityEngine;

public class Keybindings_Manager : MonoBehaviour
{
    private static Keybindings_Manager instance;

    public Scriptable_Obj_Keybindings keybindings;

    public KeyCode moveUp, moveLeft, moveDown, moveRight, shootUpTurret, shootDownTurret, shootRocket;

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

    public static Keybindings_Manager MyInstance
    {
        get
        {
            return instance;
        }
    }

    private void Start()
    {
        SetDefaultKeybindings();
    }

    public void SetDefaultKeybindings()
    {
        SetKey("moveUp1", KeyCode.W);
        SetKey("moveLeft1", KeyCode.A);
        SetKey("moveDown1", KeyCode.S);
        SetKey("moveRight1", KeyCode.D);
        SetKey("shootUpTurret1", KeyCode.X);
        SetKey("shootDownTurret1", KeyCode.C);
        SetKey("shootRocket1", KeyCode.V);



        SetKey("moveUp2", KeyCode.UpArrow);
        SetKey("moveLeft2", KeyCode.LeftArrow);
        SetKey("moveDown2", KeyCode.DownArrow);
        SetKey("moveRight2", KeyCode.RightArrow);
        SetKey("shootUpTurret2", KeyCode.Comma);
        SetKey("shootDownTurret2", KeyCode.Period);
        SetKey("shootRocket2", KeyCode.Slash);
    }

    public void SaveKeybindingsIfDead(int p)
    {
        moveUp = ReturnKey("moveUp" + p);
        moveLeft = ReturnKey("moveLeft" + p);
        moveDown = ReturnKey("moveDown" + p);
        moveRight = ReturnKey("moveRight" + p);
        shootUpTurret = ReturnKey("shootUpTurret" + p);
        shootDownTurret = ReturnKey("shootDownTurret" + p);
        shootRocket = ReturnKey("shootRocket" + p);

        SetKeyWithoutUpdatingTheText("moveUp" + p, KeyCode.None);
        SetKeyWithoutUpdatingTheText("moveLeft" + p, KeyCode.None);
        SetKeyWithoutUpdatingTheText("moveDown" + p, KeyCode.None);
        SetKeyWithoutUpdatingTheText("moveRight" + p, KeyCode.None);
        SetKeyWithoutUpdatingTheText("shootUpTurret" + p, KeyCode.None);
        SetKeyWithoutUpdatingTheText("shootDownTurret" + p, KeyCode.None);
        SetKeyWithoutUpdatingTheText("shootRocket" + p, KeyCode.None);
    }

    public void SetKeybindingsIfDead(int p)
    {
        SetKeyWithoutUpdatingTheText("moveUp" + p, moveUp);
        SetKeyWithoutUpdatingTheText("moveLeft" + p, moveLeft);
        SetKeyWithoutUpdatingTheText("moveDown" + p, moveDown);
        SetKeyWithoutUpdatingTheText("moveRight" + p, moveRight);
        SetKeyWithoutUpdatingTheText("shootUpTurret" + p, shootUpTurret);
        SetKeyWithoutUpdatingTheText("shootDownTurret" + p, shootDownTurret);
        SetKeyWithoutUpdatingTheText("shootRocket" + p, shootRocket);
    }

    public void SetKey(string key, KeyCode keycode)
    {
        keybindings.SetKey(key, keycode);
    }

    public void SetKeyWithoutUpdatingTheText(string key, KeyCode keycode)
    {
        keybindings.SetKeyWithoutUpdatingTheText(key, keycode);
    }

    public KeyCode ReturnKey(string key)
    {
        return keybindings.ReturnKey(key);
    }

    public bool KeyDown(string key)
    {
        if (Input.GetKey(keybindings.ReturnKey(key)))
            return true;
        else
            return false;
    }

    public bool KeyPressDown(string key)
    {
        if (Input.GetKeyDown(keybindings.ReturnKey(key)))
            return true;
        else
            return false;
    }
}
