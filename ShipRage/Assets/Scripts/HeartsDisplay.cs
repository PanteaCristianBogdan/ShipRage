using System.Collections.Generic;
using UnityEngine;

public class HeartsDisplay : MonoBehaviour
{
    public static HeartsDisplay instance;

    public GameObject heartPrefab;

    public PlayerStat p1Stat;
    public PlayerStat p2Stat;

    public GameObject p1HealthZone;
    public GameObject p2HealthZone;

    List<Hearts> p1Hearts = new List<Hearts>();
    List<Hearts> p2Hearts = new List<Hearts>();

    public static HeartsDisplay MyInstance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DrawHearts();
    }

    private void ClearHearts()
    {
        foreach (Transform t in p1HealthZone.transform)
            Destroy(t.gameObject);

        foreach (Transform t in p2HealthZone.transform)
            Destroy(t.gameObject);

        p1Hearts = new List<Hearts>();
        p2Hearts = new List<Hearts>();
    }

    private void CreateEmptyHeart(int p)
    {
        if (p == 1)
        {
            GameObject newHeart = Instantiate(heartPrefab);
            newHeart.transform.SetParent(p1HealthZone.transform);

            newHeart.GetComponent<Hearts>().SetHeartImage(Hearts.HeartStatus.Empty);
            p1Hearts.Add(newHeart.GetComponent<Hearts>());
        }
        else if (p == 2)
        {
            GameObject newHeart = Instantiate(heartPrefab);
            newHeart.transform.SetParent(p2HealthZone.transform);
            newHeart.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 180, 0);

            newHeart.GetComponent<Hearts>().SetHeartImage(Hearts.HeartStatus.Empty);
            p2Hearts.Add(newHeart.GetComponent<Hearts>());
        }
    }

    private void DrawHearts()
    {
        ClearHearts();

        int maxHealthRestP1 = p1Stat.MaxHealth % 2;
        int heartsToMakeP1 = p1Stat.MaxHealth / 2 + maxHealthRestP1;

        int maxHealthRestP2 = p2Stat.MaxHealth % 2;
        int heartsToMakeP2 = p2Stat.MaxHealth / 2 + maxHealthRestP2;

        for (int i = 0; i < heartsToMakeP1; i++)
            CreateEmptyHeart(1);

        for (int i = 0; i < heartsToMakeP2; i++)
            CreateEmptyHeart(2);

        SetDrawHearts(1);
        SetDrawHearts(2);
    }

    public void SetDrawHearts(int p)
    {
        if (p == 1)
        {
            for (int i = 0; i < p1Hearts.Count; i++)
            {
                int heartStatusRest = Mathf.Clamp(p1Stat.Health - (i * 2), 0, 2);

                p1Hearts[i].SetHeartImage((Hearts.HeartStatus)heartStatusRest + 1);
            }
        }
        else if (p == 2)
        {
            for (int i = 0; i < p2Hearts.Count; i++)
            {
                int heartStatusRest = Mathf.Clamp(p2Stat.Health - (i * 2), 0, 2);

                p2Hearts[i].SetHeartImage((Hearts.HeartStatus)heartStatusRest + 1);
            }
        }
    }
}
