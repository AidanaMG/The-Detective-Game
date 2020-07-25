using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y4 : MonoBehaviour
{
    private float speed = 2f;


    private bool movingUp = true;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y >= 29.5f)
        {
            movingUp = false;
        }
        else if (gameObject.transform.position.y <= 21.34f)
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
