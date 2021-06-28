using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Players")
        {
            Destroy(this.gameObject);
            Score.Sscore -= 1;
        }
    }
}
