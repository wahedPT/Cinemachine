using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Players")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("hey");
        }
    }
}
