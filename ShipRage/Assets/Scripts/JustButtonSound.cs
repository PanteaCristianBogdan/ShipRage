using UnityEngine;

public class JustButtonSound : MonoBehaviour
{
    public void PlayButtonSound(string name)
    {
        Audio_Manager.MyInstance.Play(name);
    }

    public void ButtonsInteractable()
    {
        Pause_Menu_Scripts.MyInstance.ButtonsInteractable();
    }

    public void GetShip(GameObject shipPrefab)
    {
        Pause_Menu_Scripts.MyInstance.GetShip(shipPrefab);
    }
}
