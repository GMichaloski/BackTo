using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketIA : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject Player;
    private bool PrepareToFly = false;
    [SerializeField] private int Rmovespeed;
    public SpriteRenderer spr;
    public Sprite RocketFull;
    public ParticleSystem PS;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GameObject.Find("Key").GetComponent<KeyIA>().havekey == true) 
            {
                GameObject.Destroy(Player);
                PrepareToFly = true;
                spr.sprite = RocketFull;
                PS.Play();
                StartCoroutine(WaitToNextScene());
            }

        }
            

 
    }
    
    void FixedUpdate()
    {
        if (PrepareToFly)
        {
            rb.AddForce(new Vector2(0, Rmovespeed), ForceMode2D.Force);
        }
    }
    
    IEnumerator WaitToNextScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
