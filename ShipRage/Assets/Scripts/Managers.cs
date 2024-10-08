using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this);
    }

    public static Managers MyInstance
    {
        get
        {
            return instance;
        }
    }
}
