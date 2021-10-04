using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonlv2 : MonoBehaviour
{
    public GameObject portal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        portal.transform.position = new Vector2(-24, -15);
    }
}
