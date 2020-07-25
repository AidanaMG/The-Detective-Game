using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingP : MonoBehaviour
{
    Rigidbody2D rb = null;

   
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            Invoke("FallPlatform", 1.65f);
           

            Invoke("ConcealerObject", 2.65f);
           


        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Invoke("CreateObject", 3.65f);
        Debug.Log("Log");
    }



    void FallPlatform()
    {
        rb.isKinematic = false;
    }

    void CreateObject()
    {
        Debug.Log("Create");
        gameObject.transform.position =  new Vector3(0,0,0);
        rb.isKinematic = true;
        gameObject.SetActive(true);
    }

    void ConcealerObject()
    {
        gameObject.SetActive(false);
      
    }
}
