﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFromCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        //Debug the ray so it's visible
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red);
        
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            // Do something with the object that was hit by the raycast.
        }
    }
}
