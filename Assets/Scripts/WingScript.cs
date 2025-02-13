using UnityEngine;
using System.Collections;

public class WingScript : MonoBehaviour
{
    public AudioClip flapSound;

    private SpriteRenderer wingSprite;
    private AudioSource audioSource;

    void Start()
    {
        wingSprite = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("FlapWing")]
    public void flapWing()
    {
        if (wingSprite != null)
        {
            StartCoroutine(FlapWingCoroutine());
        }
    }

    private IEnumerator FlapWingCoroutine()
    {
        wingSprite.flipY = !wingSprite.flipY;

        if (audioSource != null && flapSound != null)
        {
            audioSource.PlayOneShot(flapSound);
        }


        yield return new WaitForSeconds(0.25f);

        wingSprite.flipY = !wingSprite.flipY;
    }
}
