using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersCheck : MonoBehaviour
{
    [SerializeField]
    InputField field;

    [SerializeField]
   private GameObject resultPanel = null, correct = null, incorrect = null;

    [SerializeField]
   private MiniGame mini;

    [SerializeField]
    private GameObject hints = null;


    [SerializeField]
    private GameObject ob = null;

   [SerializeField]
    SaveData save;

    private int whichOne2;

  
  
  

    public InputField Field1 { get => field; set => field = value; }

    private void Start()
    {
       
       mini = mini.GetComponent<MiniGame>();
        save = save.GetComponent<SaveData>();
      
    }

    public void Update()
    {
        whichOne2 = mini.GetComponent<MiniGame>().identity;

        
    }

    

    
    public void CheckAWord()
    {
     
        switch (whichOne2) 
        {
            case 1:
                if (Field1.text == "Rainbow")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);
              
                }
                else
                {
                   
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                } break;

            case 2:
                if (Field1.text == "636")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 3:
                if (Field1.text == "Интеллект")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;


            case 4:
                if (Field1.text == "Snake")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 5:
                if (Field1.text == "3")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 6:
                if (Field1.text == "3")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;


            case 7:
                if (Field1.text == "Gorgeous")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 8:
                if (Field1.text == "3")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 9:
                if (Field1.text == "Правда")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 10:
                if (Field1.text == "Ignorant")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 11:
                if (Field1.text == "3")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;

            case 12:
                if (Field1.text == "Sheldon")
                {
                    Debug.Log(Field1.text);
                    resultPanel.SetActive(true);
                    incorrect.SetActive(false);
                    correct.SetActive(true);

                }
                else
                {
                    resultPanel.SetActive(true);
                    incorrect.SetActive(true);
                }
                break;
        }

        
       
    }

    

    public void CloseTheResult ()
    {
      
        switch (mini.GetComponent<MiniGame>().identity)
        {
            case 1:
                if (Field1.text == "Rainbow")
                {
                   
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);


                }
                else
                resultPanel.SetActive(false);
               
                break;

            case 2:
                if (Field1.text == "636")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);

                }
                else
                resultPanel.SetActive(false);
               
                break;

            case 3:
                if (Field1.text == "Интеллект")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);
                }
                else
                    resultPanel.SetActive(false);

                break;


            case 4:
                if (Field1.text == "Snake")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);

                }
                else
                    resultPanel.SetActive(false);

                break;

            case 5:
                if (Field1.text == "3")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);

                }
                else
                    resultPanel.SetActive(false);

                break;

            case 6:
                if (Field1.text == "3")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);

                }
                else
                    resultPanel.SetActive(false);

                break;

            case 7:
                if (Field1.text == "Gorgeous")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);

                }
                else
                    resultPanel.SetActive(false);

                break;

            case 8:
                if (Field1.text == "3")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);


                }
                else
                    resultPanel.SetActive(false);

                break;

            case 9:
                if (Field1.text == "Правда")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);


                }
                else
                    resultPanel.SetActive(false);

                break;

            case 10:
                if (Field1.text == "Ignorant")
                {
                   
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);


                }
                else
                    resultPanel.SetActive(false);

                break;

            case 11:
                if (Field1.text == "3")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);


                }
                else
                    resultPanel.SetActive(false);

                break;

            case 12:
                if (Field1.text == "Sheldon")
                {
                    Destroy(ob);
                    mini.GetComponent<MiniGame>().Resume();
                    hints.SetActive(true);
                    int num = 1;
                    save.Cons(num);


                }
                else
                    resultPanel.SetActive(false);

                break;
        }


       
    }


   
    

}
