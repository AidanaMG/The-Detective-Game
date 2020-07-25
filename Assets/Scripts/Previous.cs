using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Previous : MonoBehaviour
{
    [SerializeField]
    GameObject buttonPlay, environment, contr, contr2;
    [SerializeField]
    Button current, current2;


    public void Controller()
    {

        buttonPlay.SetActive(true);
        environment.SetActive(true);
        contr.SetActive(false);
        contr2.SetActive(false);
        current.enabled = true;
        current2.enabled = true;

        Debug.Log(gameObject.name);

    }

   
}
