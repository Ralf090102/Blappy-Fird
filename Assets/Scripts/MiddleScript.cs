using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logicScript;
    public BirdScript birdScript;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3 && birdScript.birdIsAlive)
        {
            logicScript.addScore(1);
        }
    }
}
