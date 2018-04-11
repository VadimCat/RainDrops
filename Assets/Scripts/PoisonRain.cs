using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PoisonRain : MonoBehaviour
{

    public GameObject AnimBlow;

    private MainScript mainscript;
    void Start()
    {
        Input.simulateMouseWithTouches = true;//touch=click
        mainscript = GameObject.Find("MAIN").GetComponent<MainScript>();
    }

    private void OnTriggerStay2D(Collider2D collision)  //VOIDZONE
    {
        Destroy(gameObject);
        mainscript.scoreText.text = "Score: " + mainscript.score.ToString() + " Lives: " + mainscript.lives.ToString();
    }
    void OnMouseDown()//CLICK
    {
        if (!mainscript.pause)
        {
            Destroy(gameObject);
            mainscript.lives--;
        }             
    }
    private void OnDestroy()
    {
        Instantiate(AnimBlow, gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, mainscript.speed/1.2f * Time.deltaTime, 0);
    }
}
