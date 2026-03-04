using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacle;

    private float _spawnFrequency = 3f;

    private float _timeTillNextSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if(_timeTillNextSpawn <= 0f)
        {
            Instantiate(_obstacle, transform.position, transform.rotation);
            _timeTillNextSpawn = _spawnFrequency;
        }
        else
        {
            _timeTillNextSpawn -= Time.deltaTime;
        }
    }
}
