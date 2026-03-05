using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5; // hur snabbt pipes rör sig åt vänster
    public float deadZone = -45; // position där pipe tas bort

    // Update körs varje frame
    void Update()
    {
        // flyttar pipe åt vänster hela tiden
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // om pipe åker utanför skärmen förstörs den
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}