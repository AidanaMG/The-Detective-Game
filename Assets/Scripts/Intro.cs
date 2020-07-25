using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField]
    private GameObject first = null, second = null, third = null, fourth = null, fifth = null;


  

    private void Start()
    {
        Debug.Log("Start");
        Invoke("First", 0.1f);
        Invoke("Second", 2.1f);
        Invoke("Third", 4.1f);
        Invoke("Fourth", 6.1f);
        Invoke("Fifth", 8.1f);
        Debug.Log("End");


    }


    private void First()
    {
        first.SetActive(true);
    }

    private void Second()
    {
        second.SetActive(true);
    }

    private void Third()
    {
        third.SetActive(true);
    }

    private void Fourth()
    {
        fourth.SetActive(true);
    }

    private void Fifth()
    {
        fifth.SetActive(true);
    }
    public void GameLoad()
    {
        Close();
        SceneManager.LoadScene(1);
    }

    public void Close()
    {
        first.SetActive(false);
        second.SetActive(false);
        third.SetActive(false);
        fourth.SetActive(false);
        fifth.SetActive(false);
    }

    
}

