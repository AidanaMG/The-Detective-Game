using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    private bool turnOn;
    Character obj;

    public static bool gameIsPaused = false;

    [SerializeField]
    private GameObject panel1 = null,
        panel2 = null, 
        panel3 = null, 
        panel4 = null, 
        panel5 = null,
        panel6 = null,
        panel7 = null, 
        panel8 = null, 
        panel9 = null, 
        panel10 = null, 
        panel11 = null, 
        panel12 = null;
    
    public GameObject panelPolice, policeC, policeI;

   
    public int identity;

    private void Start()
    {
        obj = GetComponent<Character>();
    }

    public void Update()
    {
        
        identity = obj.whichOne;
        Debug.Log("identity " + identity);

        turnOn = obj.switcher;

        if (turnOn && Input.GetKeyDown(KeyCode.Return))
        {
            if (gameIsPaused)
            {
                Debug.Log(identity);
                Resume();
            }
            else
            {
                Debug.Log(identity);
                Pause();
            }
        }

        turnOn = false; }

    public  void Resume()
    {
        Debug.Log("Resume" + identity);
       
        switch (identity)
        {
            case 1:
                panel1.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 2:
                panel2.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 3:
                panel3.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 4:
                panel4.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 5:
                panel5.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 6:
                panel6.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 7:
                panel7.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 8:
                panel8.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 9:
                panel9.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 10:
                panel10.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 11:
                panel11.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;
            case 12:
                panel12.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;

            case 13:
                policeC.SetActive(false);
                policeI.SetActive(false);
                panelPolice.SetActive(false);
                Time.timeScale = 1F;
                gameIsPaused = false;
                break;

        }
            
        

       
    }

    void Pause()
    {
        Debug.Log("Pause" + identity);
        switch (identity)
        {
            case 1:
                panel1.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 2:
                panel2.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 3:
                panel3.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 4:
                panel4.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 5:
                panel5.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 6:
                panel6.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 7:
                panel7.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 8:
                panel8.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 9:
                panel9.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 10:
                panel10.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 11:
                panel11.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;
            case 12:
                panel12.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;

            case 13:
                panelPolice.SetActive(true);
                Time.timeScale = 0F;
                gameIsPaused = true;
                break;


        }
    }
}
