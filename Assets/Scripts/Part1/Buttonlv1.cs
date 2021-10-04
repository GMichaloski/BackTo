using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonlv1 : MonoBehaviour
{
    public Animator anim;
    public bool vasco;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vasco = true;
            anim.SetBool("BP", true);

        }


    }
}
    
