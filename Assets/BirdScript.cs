using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        // hittar Logic Manager i scenen
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            // gör så fisken hoppar upp
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }

        // rotation baserat på velocity
        float rotation = myRigidBody.linearVelocity.y * 5;
        rotation = Mathf.Clamp(rotation, -90, 45);
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // när man träffar något → game over
        logic.gameOver();
        birdIsAlive = false;
    }
}