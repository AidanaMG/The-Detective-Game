using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    private int count = 0;

    [SerializeField]
    private Text mytext = null;
    public void Cons(int x)
    {
        count += x;
        Debug.Log(count);
        mytext.text = count.ToString();
    }

   
}
