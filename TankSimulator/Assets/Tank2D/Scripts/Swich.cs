using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich : MonoBehaviour
{
    private Camera MainCamera;
    public Camera SecondCamera;
   
    void Start()
    {
        MainCamera = GetComponent<Camera>();
        MainCamera = Camera.main;
    }


   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            MainCamera.enabled = !MainCamera.enabled;
            SecondCamera.enabled = !SecondCamera.enabled;

        }

        
    }
}
