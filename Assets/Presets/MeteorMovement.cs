using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] int minspeed;
    [SerializeField] int maxspeed;
    void Start()
    {
        rb.AddForce(new Vector2(Random.Range(-minspeed,-maxspeed-1), 0), ForceMode2D.Impulse);
    }
}
