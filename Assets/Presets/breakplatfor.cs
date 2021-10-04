using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakplatfor : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public ParticleSystem PS;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}
