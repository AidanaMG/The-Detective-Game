using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute2 : MonoBehaviour
{
   
  
    new AudioSource audio;
    int m;


    void Awake()
    { 
     
        audio = GetComponent<AudioSource>();
        m = PlayerPrefs.GetInt("music");
        Debug.Log(PlayerPrefs.GetInt("music"));

        if (m == 1)
        {
            audio.mute = false;
            Debug.Log(PlayerPrefs.GetInt("music"));

        }
        else
        {
            audio.mute = true;
            Debug.Log(PlayerPrefs.GetInt("music"));

        }

       
    }

   
 
}
