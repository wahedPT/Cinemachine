using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile :Tile
{
    [SerializeField] GameObject applePrefab;
    GameObject apple;
   // public GameObject gridTilePrefab;
    bool hasApple = false;


    public bool Hasapple()
    {
        return hasApple;
    }
    public bool Setapple()
    {
        if(hasApple)
        {
            return false;
        }
        else
        {
            apple = Instantiate(applePrefab, transform.position, Quaternion.identity);
            apple.transform.parent = transform;
            hasApple = true;
            return true;
        }
    }
    public bool TakeApple()
    {
        if(!hasApple)
        {
            return false;
        }
        else
        {
            hasApple = false;
            Destroy(apple.gameObject);
            apple = null;
            return true;
        }
    }
}
