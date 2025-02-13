using UnityEngine;

public class PipeScript : MonoBehaviour
{

    public float pipeSpeed = 5;
    public float deadZone = -40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= deadZone)
        {
            Destroy(gameObject);
        }

        moveObject();
    }

    protected virtual void moveObject()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
    }
}
