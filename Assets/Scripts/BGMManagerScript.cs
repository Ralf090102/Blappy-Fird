using UnityEngine;

public class BGMManagerScript : MonoBehaviour
{
    public AudioClip bgmClip;

    private AudioSource audioSource;

    private static BGMManagerScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            if (audioSource != null )
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
            audioSource.clip = bgmClip;
            audioSource.loop = true;
            audioSource.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
