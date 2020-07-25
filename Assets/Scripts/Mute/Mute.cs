using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    new AudioSource audio;
    Image image;

    public Sprite pic1;
    public Sprite pic2;
    private Image im;

    

    void Start()
    {
       

        audio = GetComponent<AudioSource>();
        image = GetComponent<Image>();

        im = GetComponent<Image>();
        im.sprite = pic1;
        PlayerPrefs.SetInt("music", 1);
        Debug.Log(PlayerPrefs.GetInt("music"));
    }

    public void MuteTheMusic()
    {
       

        if (audio.mute)
        {
            audio.mute = false;
            PlayerPrefs.SetInt("music", 1);
            Swap();
            Debug.Log(PlayerPrefs.GetInt("music"));
        }
        else
        {
            audio.mute = true;
            PlayerPrefs.SetInt("music", 0);
            Swap();
            Debug.Log(PlayerPrefs.GetInt("music"));
        }
       
       


    }

       
        public void Swap()
        {
            if (im.sprite == pic1)
            {
                im.sprite = pic2;
                return;
            }

            if (im.sprite == pic2)
            {
                im.sprite = pic1;
                return;
            }
        }
    }

