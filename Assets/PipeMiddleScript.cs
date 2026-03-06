using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    void Start()
    {
        // hittar Logic Manager via tag
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // kollar om det är spelaren som flyger igenom
        if (collision.CompareTag("Player"))
        {
            logic.addScore(1); // öka score med 1
        }
    }
}