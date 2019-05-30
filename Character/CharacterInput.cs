using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{ 
    private float vertical;
    public float Vertical
    {
        get
        {
            return vertical;
        }
        set
        {
            vertical = value;
        }
    }

    private float visionHorizontal;
    public float VisionHorizontal
    {
        get
        {
            return visionHorizontal;
        }
        set
        {
            visionHorizontal = value;
        }
    }

    private float horizontal;
    public float Horizontal
    {
        get
        {
            return horizontal;
        }
        set
        {
            horizontal = value;
        }
    }

    public Action OnShoot;

    private void Update()
    {
        VisionHorizontal = Input.GetAxis("Mouse X");
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Mouse0))
            OnShoot.Invoke();
    }
}
