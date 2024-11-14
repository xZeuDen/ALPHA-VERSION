using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Transform player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
    
        if (transform.position.z < player.position.z - 10f)
        {
            Destroy(gameObject);
        }
    }
}
