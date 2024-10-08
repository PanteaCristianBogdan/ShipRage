using UnityEngine;

[CreateAssetMenu(fileName = "Keybindings", menuName = "Keybindings")]
public class Scriptable_Obj_Keybindings : ScriptableObject
{
    [Header("Player1_Controls")]
    public KeyCode moveUp1;
    public KeyCode moveLeft1, moveDown1, moveRight1, shootUpTurret1, shootDownTurret1, shootRocket1;

    [Space(20)]
    [Header("Player2_Controls")]
    public KeyCode moveUp2;
    public KeyCode moveLeft2, moveDown2, moveRight2, shootUpTurret2, shootDownTurret2, shootRocket2;

    public void SetKey(string key, KeyCode keycode)
    {
        switch (key)
        {
            case "moveUp1":
                moveUp1 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveUp1", keycode);
                return;

            case "moveLeft1":
                moveLeft1 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveLeft1", keycode);
                return;

            case "moveDown1":
                moveDown1 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveDown1", keycode);
                return;

            case "moveRight1":
                moveRight1 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveRight1", keycode);
                return;

            case "shootUpTurret1":
                shootUpTurret1 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("shootUpTurret1", keycode);
                return;

            case "shootDownTurret1":
                shootDownTurret1 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("shootDownTurret1", keycode);
                return;

            case "shootRocket1":
                shootRocket1 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("shootRocket1", keycode);
                return;



            case "moveUp2":
                moveUp2 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveUp2", keycode);
                return;

            case "moveLeft2":
                moveLeft2 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveLeft2", keycode);
                return;

            case "moveDown2":
                moveDown2 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveDown2", keycode);
                return;

            case "moveRight2":
                moveRight2 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("moveRight2", keycode);
                return;

            case "shootUpTurret2":
                shootUpTurret2 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("shootUpTurret2", keycode);
                return;

            case "shootDownTurret2":
                shootDownTurret2 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("shootDownTurret2", keycode);
                return;

            case "shootRocket2":
                shootRocket2 = keycode;
                UIManager.MyInstance.SetKeybindingsButtonsText("shootRocket2", keycode);
                return;

            default:
                break;
        }
    }

    public KeyCode ReturnKey(string key)
    {
        switch (key)
        {
            case "moveUp1":
                return moveUp1;

            case "moveLeft1":
                return moveLeft1;

            case "moveDown1":
                return moveDown1;

            case "moveRight1":
                return moveRight1;

            case "shootUpTurret1":
                return shootUpTurret1;

            case "shootDownTurret1":
                return shootDownTurret1;

            case "shootRocket1":
                return shootRocket1;



            case "moveUp2":
                return moveUp2;

            case "moveLeft2":
                return moveLeft2;

            case "moveDown2":
                return moveDown2;

            case "moveRight2":
                return moveRight2;

            case "shootUpTurret2":
                return shootUpTurret2;

            case "shootDownTurret2":
                return shootDownTurret2;

            case "shootRocket2":
                return shootRocket2;

            default:
                return KeyCode.None;
        }
    }

    public void SetKeyWithoutUpdatingTheText(string key, KeyCode keycode)
    {
        switch (key)
        {
            case "moveUp1":
                moveUp1 = keycode;
                return;

            case "moveLeft1":
                moveLeft1 = keycode;
                return;

            case "moveDown1":
                moveDown1 = keycode;
                return;

            case "moveRight1":
                moveRight1 = keycode;
                return;

            case "shootUpTurret1":
                shootUpTurret1 = keycode;
                return;

            case "shootDownTurret1":
                shootDownTurret1 = keycode;
                return;

            case "shootRocket1":
                shootRocket1 = keycode;
                return;



            case "moveUp2":
                moveUp2 = keycode;
                return;

            case "moveLeft2":
                moveLeft2 = keycode;
                return;

            case "moveDown2":
                moveDown2 = keycode;
                return;

            case "moveRight2":
                moveRight2 = keycode;
                return;

            case "shootUpTurret2":
                shootUpTurret2 = keycode;
                return;

            case "shootDownTurret2":
                shootDownTurret2 = keycode;
                return;

            case "shootRocket2":
                shootRocket2 = keycode;
                return;

            default:
                break;
        }
    }
}
