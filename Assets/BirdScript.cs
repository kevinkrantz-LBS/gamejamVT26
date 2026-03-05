using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody; // referens till birdens Rigidbody
    public float flapStrength; // hur starkt hoppet ska vara
    public bool birdIsAlive = true; // används senare för game over

    // Start körs när spelet startar
    void Start()
    {

    }

    // Update körs varje frame
    void Update()
    {
        // kollar om spelaren trycker space och om fågeln fortfarande lever
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            // ger fågeln en uppåt kraft
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}