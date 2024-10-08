using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    private int health;
    private int maxHealth;

    private int player;

    public int Health
    {
        set { health = value; }

        get { return health; }
    }

    public int MaxHealth
    {
        get { return maxHealth; }
    }

    private void Awake()
    {
        if (this.CompareTag("Player1"))
            player = 1;
        else if (this.CompareTag("Player2"))
            player = 2;

        maxHealth = 6;
        health = maxHealth;
    }

    private void Start()
    {
        Pause_Menu_Scripts.MyInstance.dead = false;
    }

    private void CheckHealth()
    {
        if (health <= 0)
        {
            health = 0;

            if (!Pause_Menu_Scripts.MyInstance.dead)
                Dead();
        }

        if (health >= maxHealth)
            health = maxHealth;
    }

    public void Damage(int damage)
    {
        health -= damage;
        CheckHealth();
        HeartsDisplay.MyInstance.SetDrawHearts(player);
    }

    public void Heal(int heal)
    {
        health += heal;
        CheckHealth();
        HeartsDisplay.MyInstance.SetDrawHearts(player);
    }

    public void ResetHealth()
    {
        health = MaxHealth;
        HeartsDisplay.MyInstance.SetDrawHearts(player);
    }

    public void Dead()
    {
        Pause_Menu_Scripts.MyInstance.dead = true;
        Keybindings_Manager.MyInstance.SaveKeybindingsIfDead(player);
        Pause_Menu_Scripts.MyInstance.Won(player);

        Pause_Menu_Scripts.MyInstance.ExplosionInitialisation(player);
        Pause_Menu_Scripts.MyInstance.SmokeDeactivate(player);

        Pause_Menu_Scripts.MyInstance.KillsUpdate(player);

        Audio_Manager.MyInstance.Play("ShipExplosion");
    }
}
