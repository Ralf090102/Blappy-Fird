using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public AudioClip gameOverSound;
    public Rigidbody2D birdRigidBody;
    public float flapStrength;
    public bool birdIsAlive = true;
    public LogicScript logicScript;
    public WingScript wing;

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidBody.linearVelocity = Vector2.up * flapStrength;
            wing.flapWing();
        }

    }

    public void birdDead()
    {
        if (audioSource != null && gameOverSound != null && birdIsAlive)
        {
            audioSource.PlayOneShot(gameOverSound);
        }

        logicScript.gameOver();
        birdIsAlive = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdDead();
    }
}
