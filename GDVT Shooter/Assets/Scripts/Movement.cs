using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //This number will decide how fast the player will be moving.
    public float currentSpeed;

    void Update()
    {

        //check for input. If there's W input, it means the player is moving.
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            currentSpeed = 1;
        }
        //Move the player according to input.
        this.transform.Translate(new Vector3(0, 0, currentSpeed) * Time.deltaTime);

        currentSpeed = 0;
    }
}
