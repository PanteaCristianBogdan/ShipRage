using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    private static Audio_Manager instance;

    public Sounds[] sounds;

    public float mainVolume;

    public static Audio_Manager MyInstance
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

        foreach (Sounds sound in sounds)
        {
            sound.audioSource = gameObject.AddComponent<AudioSource>();
            sound.audioSource.clip = sound.audio;

            sound.audioSource.loop = sound.loop;
            sound.audioSource.volume = sound.volume * mainVolume;
            sound.audioSource.pitch = sound.pitch;
        }
    }

    private void Start()
    {
        Play("BackgroundMusic");
    }

    public void OnValueChanged()
    {
        mainVolume = Main_Menu_Script.MyInstance.slider.value;

        foreach (Sounds sound in sounds)
        {
            sound.audioSource.volume = sound.volume * mainVolume;
        }
    }

    public void Play(string name)
    {
        foreach (Sounds sound in sounds)
        {
            if (name == sound.name)
            {
                sound.audioSource.Play();
                return;
            }
        }
    }
}
