using UnityEngine;

public class Rocket_Script : MonoBehaviour
{
    public string player;
    public GameObject playerStat;
    public GameObject enemy;

    public float speed;
    public float rotationSpeed;
    public float rotationModifier;

    private float flyingTime;

    private void Start()
    {
        flyingTime = 5f;

        if (player == "1")
            enemy = Pause_Menu_Scripts.MyInstance.P1StartPoint;
        else if (player == "2")
            enemy = Pause_Menu_Scripts.MyInstance.P2StartPoint;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        Vector3 vectorToTarget = enemy.transform.position - transform.position;

        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, rotationSpeed * Time.deltaTime);


        flyingTime -= Time.deltaTime;

        if (flyingTime <= 0)
        {
            Destroy(gameObject);
            Instantiate(Pause_Menu_Scripts.MyInstance.rocketExplosion_Prefab, gameObject.transform.position, gameObject.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(("Player") + player))
        {
            other.gameObject.GetComponent<PlayerStat>().Damage(3);
            Instantiate(Pause_Menu_Scripts.MyInstance.rocketExplosion_Prefab, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);

            Audio_Manager.MyInstance.Play("RocketExplosion");

            playerStat.GetComponent<PlayerStat>().Heal(2);
        }
    }
}
