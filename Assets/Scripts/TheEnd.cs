using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheEnd : MonoBehaviour
{

    [SerializeField]
    InputField fieldPolice;

    [SerializeField]
    protected GameObject  correctP = null, incorrectP = null;

    [SerializeField]
    protected MiniGame miniP;

    public InputField FieldP { get => fieldPolice; set => fieldPolice = value; }

    private void Start()
    {

        miniP = miniP.GetComponent<MiniGame>();
    }

    public void Police()
    {
        switch (FieldP.text)
        {
            case "Марта":
                miniP.panelPolice.SetActive(false);
                correctP.SetActive(false);
                incorrectP.SetActive(true);
                break;

            case "Брюс":
                miniP.panelPolice.SetActive(false);
                correctP.SetActive(false);
                incorrectP.SetActive(true);
                break;

            case "Джон":
                miniP.panelPolice.SetActive(false);
                correctP.SetActive(false);
                incorrectP.SetActive(true);
                break;

            case "Сэм":
                miniP.panelPolice.SetActive(false);
                incorrectP.SetActive(false);
                correctP.SetActive(true);
                break;

        }

    }





}

