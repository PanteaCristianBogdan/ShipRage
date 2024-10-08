using UnityEngine;

public class Ship_Shooting : MonoBehaviour
{
    public Transform shootUpTurret;
    public Transform shootDownTurret;
    public Transform shootRocket;

    public GameObject bulletPrefab;
    public GameObject rocketPrefab;

    private string player;

    public int bullets1;
    public float bulletsTimmer1;
    public float bulletsRealTimmer1;
    
    public int bullets2;
    public float bulletsTimmer2;
    public float bulletsRealTimmer2;

    public int rockets;
    public float rocketsTimmer;
    public float rocketsRealTimmer;

    // Start is called before the first frame update
    void Start()
    {
        if (this.CompareTag("Player1"))
            player = "1";
        else if (this.CompareTag("Player2"))
            player = "2";

        bullets1 = 3;
        bulletsTimmer1 = 3f;
        bulletsRealTimmer1 = 0f;

        bullets2 = 3;
        bulletsTimmer2 = 3f;
        bulletsRealTimmer2 = 0f;

        rockets = 0;
        rocketsTimmer = 7f;
        rocketsRealTimmer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Pause_Menu_Scripts.MyInstance.IsPaused)
        {
            if (bulletsRealTimmer1 > 0)
                bulletsRealTimmer1 -= Time.deltaTime;
            
            if (bulletsRealTimmer2 > 0)
                bulletsRealTimmer2 -= Time.deltaTime;

            if (rocketsRealTimmer > 0)
                rocketsRealTimmer -= Time.deltaTime;

            if (bulletsRealTimmer1 <= 0)
                AddBullet1();

            if (bulletsRealTimmer2 <= 0)
                AddBullet2();

            if (rocketsRealTimmer <= 0)
                AddRocket();

            if (Keybindings_Manager.MyInstance.KeyPressDown("shootUpTurret" + player) && RemoveBullet1())
            {
                Audio_Manager.MyInstance.Play("Pew");
                GameObject bullet1 = Instantiate(bulletPrefab, shootUpTurret.transform.position, shootUpTurret.transform.rotation);

                if (player == "1")
                    bullet1.GetComponent<Bullet_Script>().player = "2";
                else if (player == "2")
                    bullet1.GetComponent<Bullet_Script>().player = "1";

                bullet1.GetComponent<Bullet_Script>().playerStat = this.gameObject;
            }

            if (Keybindings_Manager.MyInstance.KeyPressDown("shootDownTurret" + player) && RemoveBullet2())
            {
                Audio_Manager.MyInstance.Play("Pew");
                GameObject bullet2 = Instantiate(bulletPrefab, shootDownTurret.transform.position, shootDownTurret.transform.rotation);

                if (player == "1")
                    bullet2.GetComponent<Bullet_Script>().player = "2";
                else if (player == "2")
                    bullet2.GetComponent<Bullet_Script>().player = "1";

                bullet2.GetComponent<Bullet_Script>().playerStat = this.gameObject;
            }

            if (Keybindings_Manager.MyInstance.KeyPressDown("shootRocket" + player) && RemoveRocket())
            {
                Audio_Manager.MyInstance.Play("RocketShoot");

                GameObject rocket = Instantiate(rocketPrefab, shootRocket.transform.position, shootRocket.transform.rotation);

                if (player == "1")
                    rocket.GetComponent<Rocket_Script>().player = "2";
                else if (player == "2")
                    rocket.GetComponent<Rocket_Script>().player = "1";

                rocket.GetComponent<Rocket_Script>().playerStat = this.gameObject;
            }
        }
    }

    public void ResetAmmo()
    {
        bullets1 = 3;
        bulletsRealTimmer1 = 0f;

        bullets2 = 3;
        bulletsRealTimmer2 = 0f;

        rockets = 1;
        rocketsRealTimmer = 0f;
    }

    private void AddBullet1()
    {
        if (bullets1 < 3)
        {
            bullets1++;
            bulletsRealTimmer1 = bulletsTimmer1;
        }
        
        if (bullets1 == 3)
            bulletsRealTimmer1 = 0f;
    }

    private bool RemoveBullet1()
    {
        if (bullets1 > 0)
        {
            bullets1--;
            bulletsRealTimmer1 = bulletsTimmer1;
            return true;
        }

        return false;
    }

    private void AddBullet2()
    {
        if (bullets2 < 3)
        {
            bullets2++;
            bulletsRealTimmer2 = bulletsTimmer2;
        }

        if (bullets2 == 3)
            bulletsRealTimmer2 = 0f;
    }

    private bool RemoveBullet2()
    {
        if (bullets2 > 0)
        {
            bullets2--;
            bulletsRealTimmer2 = bulletsTimmer2;
            return true;
        }

        return false;
    }

    private void AddRocket()
    {
        if (rockets < 1)
        {
            rockets++;
            rocketsRealTimmer = rocketsTimmer;
        }
        
        if (rockets == 1)
            rocketsRealTimmer = 0f;
    }

    private bool RemoveRocket()
    {
        if (rockets > 0)
        {
            rockets--;
            rocketsRealTimmer = rocketsTimmer;
            return true;
        }

        return false;
    }
}
