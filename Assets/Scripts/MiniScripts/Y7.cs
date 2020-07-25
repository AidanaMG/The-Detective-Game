using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y7 : MonoBehaviour
{
    private float speed = 2f;


    private bool movingUp = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.transform.position.y >= 27.91f)
        {
            movingUp = false;
        }
        else if (gameObject.transform.position.y <= 20f)
        {
            movingUp = true;

        }

        if (movingUp)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + speed * Time.deltaTime, gameObject.transform.position.z);

        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - speed * Time.deltaTime, gameObject.transform.position.z);
        }
    }
}
