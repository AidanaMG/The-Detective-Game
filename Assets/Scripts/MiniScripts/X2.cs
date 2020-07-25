﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X2 : MonoBehaviour
{
    private float speed = 2f;

    private bool movingRight = true;


    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= 52.01f)
        {
            movingRight = false;
        }
        else if (gameObject.transform.position.x <= 44.77f)
        {
            movingRight = true;

        }

        if (movingRight)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);

        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
