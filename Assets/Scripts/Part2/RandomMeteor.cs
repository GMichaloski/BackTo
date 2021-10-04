using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class RandomMeteor : MonoBehaviour
{
    public GameObject Meteor1;
    public GameObject Meteor2;
    public GameObject Meteor3;
    [SerializeField] private float RespawnTime;
    private int randomspawn;
    private bool isready = false;

    void Start()
    {        
        StartCoroutine(WaitForReady());
    }
    private void FixedUpdate()
    {
        if (isready)
        {
            StartCoroutine(SpawnMeteors());
            isready = false;
        }
    }
    IEnumerator SpawnMeteors()
    {   

        randomspawn = Random.Range(1, 4);
        if (randomspawn == 1)
        {
            yield return new WaitForSeconds(RespawnTime);
            SpawnM1();
        }
        if (randomspawn == 2)
        {
            yield return new WaitForSeconds(RespawnTime);
            SpawnM2();
        }
        if (randomspawn == 3)
        {
            yield return new WaitForSeconds(RespawnTime);
            SpawnM3();
        }
    }
    void SpawnM1()
    {

        GameObject a = Instantiate(Meteor1) as GameObject;
        a.transform.position = new Vector2(4, Random.Range(-9, 7));
        isready = true;
            
            } 
    void SpawnM2()
    {
        GameObject b = Instantiate(Meteor2) as GameObject;
        b.transform.position = new Vector2(4, Random.Range(-9, 7));
        isready = true;
    }
    void SpawnM3()
    {
        GameObject c = Instantiate(Meteor3) as GameObject;
        c.transform.position = new Vector2(4, Random.Range(-9, 7));
        isready = true;
    }

    IEnumerator WaitForReady()
    {
        yield return new WaitForSeconds(5);
        isready = true;
        Debug.Log("Meteors Ready!");
    }
}
