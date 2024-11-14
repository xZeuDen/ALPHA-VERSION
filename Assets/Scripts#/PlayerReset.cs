using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerReset : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with an obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Reload the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Player hit an obstacle. Reloading the scene.");
        }
    }
}
