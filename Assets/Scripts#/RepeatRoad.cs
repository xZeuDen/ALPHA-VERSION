using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    public float roadLength = 30f;
    public Transform playerCar;

    void Update()
    {
        if (transform.position.z + roadLength < playerCar.position.z)
        {
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + roadLength * 2);
            transform.position = newPosition;
        }
    }
}
