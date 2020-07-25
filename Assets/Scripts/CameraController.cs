using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    

    [SerializeField]
    private float speed = 2.0F;

    [SerializeField]
    private Transform target;

    private void Awake()
    {
        if (!target) target = FindObjectOfType<Character>().transform;
    }

    private void Update()
    {
        Vector3 position = target.position;  
        position.z = 0.0F;

        if (position.y >= 1) { position.y = target.position.y; position.x = target.position.x; }
        else
        { position.y = 1; position.x = target.position.x; }

       
        
        if (position.x <= -10)
        {
            position.x = -10F;
           
        }
        else
           if (position.x >= 252)
        {
            position.x = 252;
          
        }


        transform.position = Vector3.Lerp(transform.position, position, speed + Time.deltaTime);

       

    }



    
}
