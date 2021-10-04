using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpykeDamage : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public ParticleSystem PS;
    public SpriteRenderer spr;
    private bool vasco = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (vasco)
            {
                PS.Play();
                PS.enableEmission = true;
                spr.enabled = false;
                vasco = false;
            }
        }
    }
}
