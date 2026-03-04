using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.left  * _moveSpeed * Time.deltaTime;
    }
}
