using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour {

    public Text scoreText,finalscore;           
    public int score,lives;
    public float speed, speed_mem;
    public GameObject cont, menu,G_O,snow;
    public bool pause=false;

    void Update()
    {                                 //СЧЕТ+ЖИТУЛЕЧКИ
        scoreText.text = "Score: " + score.ToString()+ " Lives: "+lives.ToString();
        if (lives <= 0)
        {
            gameover();
        }
            
    }
                                     
    void Start()
    {
        speed = -2f;
        lives = 3;
        pause = false;
        cont.active = false;
        menu.active = false;
        G_O.active = false;
    }

    public void Menu()
    {
        pause = false;
        Time.timeScale = 1;
        SceneManager.UnloadScene(1);
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        cont.active = true;
        menu.active = true;                    
        pause = true;
    }

    public void Continue()
    {
        cont.active = false;
        menu.active = false;
        pause = false;
        Time.timeScale = 1;
    }

    public void gameover()   
    {

        G_O.active = true;
        menu.active = true;
        pause = true;
        Time.timeScale = 0;
        finalscore.text = "FINAL SCORE: " + score.ToString() ;
    }

    public void NewGame()
    {
        Time.timeScale = 1;
        pause = false;
        SceneManager.LoadScene(1);
        lives = 3;
        score = 0;
    }
    public IEnumerator FRZ()
    {
        speed_mem = speed;
        speed = 0;
        yield return new WaitForSecondsRealtime(0.5f);
        speed = speed_mem;        
    }
}
