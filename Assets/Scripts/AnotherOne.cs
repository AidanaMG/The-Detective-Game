using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnotherOne : MonoBehaviour
{
    [SerializeField]
    GameObject  buttonPlay, environment, contr, contr2;
    [SerializeField]
    Button current, current2;


    public void Controller()
    {

        buttonPlay.SetActive(false);
        environment.SetActive(false);
        contr.SetActive(true);
        contr2.SetActive(false);
        current.enabled = false;
        current2.enabled = true;

        Debug.Log(gameObject.name);

    }

    
}
