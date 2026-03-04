using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] KeyCode flyKey = KeyCode.Space;
    public Rigidbody2D myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flyKey))
        {

            myRigidbody.linearVelocity = Vector2.up * 10;

        }
        
    }

}
       
