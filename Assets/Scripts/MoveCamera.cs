﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0f, 0f, 1);
        }

        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0f, 0f, -1);
        }

        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-1, 0f, 0f);
        }

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(1, 0f, 0f);
        }

        if(Input.GetKey("o"))
        {
            transform.position += new Vector3(0f, 1, 0f);
        }

        if(Input.GetKey("l"))
        {
            transform.position += new Vector3(0f, -1, 0f);
        }

        if (Input.GetKey("up"))
        {
            transform.Rotate(new Vector3(-1, 0f, 0f));
        }

        if (Input.GetKey("down"))
        {
            transform.Rotate(new Vector3(1, 0f, 0f));
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(new Vector3(0f, -1, 0f));
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(new Vector3(0f, 1, 0f));
        }

    }

}
