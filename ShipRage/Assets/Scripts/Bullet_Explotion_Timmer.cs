using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Explotion_Timmer : MonoBehaviour
{
    public float timmer;

    void Update()
    {
        timmer -= Time.deltaTime;
        if (timmer < 0)
            Destroy(gameObject);
    }
}
