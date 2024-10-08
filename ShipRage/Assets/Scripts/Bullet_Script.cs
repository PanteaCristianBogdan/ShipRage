using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    public string player;
    public GameObject playerStat;

    public float speed;

    private float flyingTime;

    private void Start()
    {
        flyingTime = 5f;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        flyingTime -= Time.deltaTime;

        if (flyingTime <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(("Player") + player))
        {
            other.gameObject.GetComponent<PlayerStat>().Damage(2);
            Instantiate(Pause_Menu_Scripts.MyInstance.bulletExplosion_Prefab, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
            Audio_Manager.MyInstance.Play("BulletHitSound");
            playerStat.GetComponent<PlayerStat>().Heal(1);
        }
    }
}
