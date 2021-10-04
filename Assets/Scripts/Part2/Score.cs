
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int pointsx;
    private bool readyy = false;

    void Start()
    {
        StartCoroutine(waitforready());
    }


    void Update()
    {
        StartCoroutine(points());
        ScoreText.text = "Score: " + pointsx.ToString();
    }

    IEnumerator points()
    { 
        if (readyy)
        { 
                yield return new WaitForSeconds(1);
                pointsx += 1;
        }

    }
    IEnumerator waitforready()
    {
        yield return new WaitForSeconds(5);
        readyy = true;
        
    }
}

