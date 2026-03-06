using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic; // referens till LogicScript

    void Start()
    {
        // hittar LogicManager i scenen
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // när bird flyger igenom mitten
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1); // ökar score med 1
        }
    }
}