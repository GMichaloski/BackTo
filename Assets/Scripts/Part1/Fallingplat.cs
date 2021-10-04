using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallingplat : MonoBehaviour
{
    [SerializeField] private float waittime;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb.isKinematic = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(WaitForFall());
        }
    }
    IEnumerator WaitForFall()
    {
        yield return new WaitForSeconds(waittime);
        rb.isKinematic = false;
    }
}
