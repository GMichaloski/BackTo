using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private int _movespeed;
    [SerializeField] private int _jumpforce;
    private Vector2 movement;
    public bool isGrounded;
    public SpriteRenderer spr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            rb.AddForce(new Vector2(0, _jumpforce), ForceMode2D.Impulse);
        }
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            spr.flipX = false;

        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            spr.flipX = true;
        }
    }
    private void FixedUpdate()
    {
        rb.position += movement * _movespeed * Time.fixedDeltaTime;

    }
}
