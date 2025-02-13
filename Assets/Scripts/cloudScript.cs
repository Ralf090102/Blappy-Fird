using UnityEngine;

public class CloudScript : PipeScript
{
    public float cloudSpeed = 10;

    protected override void moveObject()
    {
        transform.position = transform.position + (Vector3.left * cloudSpeed) * Time.deltaTime;
    }
}
