using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe; // prefab av pipe som ska spawnas
    public float spawnRate = 2; // hur ofta pipes spawnar
    private float timer = 0; // håller koll på tiden

    public float heightOffset = 10; // hur mycket pipes kan flyttas upp/ner

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        // ökar timern varje frame
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        // bestämmer random höjd
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe,
        new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
        transform.rotation);
    }
}