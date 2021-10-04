using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.UI;

public class RockertMove : MonoBehaviour
{
    private bool isready = false;
    private Vector2 movement;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int movespeed;
    public Animator anim;
    public ParticleSystem PS;
    public SpriteRenderer spr;
    public ParticleSystem PSD;
    public bool alive = true;
    public Text ScoreText;
    private int pointsx;
    private bool readyy = false;

    void Start()
    {
        StartCoroutine(GetReady());
        StartCoroutine(waitforready());
    }

   
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
        StartCoroutine(points());
        ScoreText.text = "Score: " + pointsx.ToString();
    }

    private void FixedUpdate()
    {
            rb.position += movement * movespeed * Time.fixedDeltaTime;
    }

    IEnumerator GetReady()
    {
        yield return new WaitForSeconds(5);
        isready = true;
        anim.enabled = false;
        Debug.Log("Ready!");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            spr.enabled = false;
            PS.Play();
            PS.enableEmission = true;
            PSD.enableEmission = false;
            alive = false;

        }
    }
    IEnumerator points()
    {
        if (readyy)
        { if (alive)
            {
                yield return new WaitForSeconds(1);
                pointsx += 1;
            }
        }

    }
    IEnumerator waitforready()
    {
        yield return new WaitForSeconds(5);
        readyy = true;

    }
}
