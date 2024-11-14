using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public bool gameOver = false;
    public float moveSpeed = 15f;
    public float turnSpeed = 45.0f;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        // Move the car forward constantly
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Turn the car
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}


