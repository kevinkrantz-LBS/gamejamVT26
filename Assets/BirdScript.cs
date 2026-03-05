using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody; // referens till birdens Rigidbody
    public float flapStrength; // hur starkt hoppet är
    public bool birdIsAlive = true; // används senare när man dör

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            // gör så fågeln/fisken hoppar upp
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }

        // roterar fisken beroende på om den åker upp eller ner
        float rotation = myRigidBody.linearVelocity.y * 5;
        rotation = Mathf.Clamp(rotation, -90, 45);
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}