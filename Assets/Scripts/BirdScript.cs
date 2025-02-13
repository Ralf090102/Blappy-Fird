using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapStrength;
    public bool birdIsAlive = true;
    public LogicScript logicScript;
    public WingScript wing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }
}
