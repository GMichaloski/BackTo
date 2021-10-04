using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RewindTime : MonoBehaviour
{
    public bool comeback = false;
    List<Vector2> positions;
    void Start()
    {
        positions = new List<Vector2>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartRewind();
       
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            StopRewind();
        }
    }
    private void FixedUpdate()
    {
        if (comeback)
        {
            Rewind();
        }
        
        else
        {
            Record();
        }
    void Rewind()
        {   if (positions.Count > 0)
            {
                transform.position = positions[0];
            
                positions.RemoveAt(0);

            }
            else
            {
                StopRewind();
        }
        }
    void Record()
        {
            positions.Insert(0, transform.position);
        }
    }
    public void StartRewind()
    {
        comeback = true;
    }
    public void StopRewind()
    {
        comeback = false;
    }
}
