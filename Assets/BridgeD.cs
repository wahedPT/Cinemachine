using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeD : MonoBehaviour
{
    public float bridgeDestroytime;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        StartCoroutine("bgDestroy");
    }
    IEnumerator bgDestroy()
    {
        yield return new WaitForSeconds(bridgeDestroytime);
        Destroy(this.gameObject);
        

    }
  
    
}
