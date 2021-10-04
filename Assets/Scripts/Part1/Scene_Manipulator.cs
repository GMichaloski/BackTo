using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manipulator : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(1920, 1080, true, 144);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }


        
    }
}
