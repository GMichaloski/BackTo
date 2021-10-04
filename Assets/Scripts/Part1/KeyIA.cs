using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIA : MonoBehaviour
{
    public bool havekey = false;
    public GameObject Item;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        havekey = true;
        Item.transform.position = new Vector2(100, 100);
        
    }
}
