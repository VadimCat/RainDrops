using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rain : MonoBehaviour {

    public GameObject AnimBlow;
   
    private MainScript mainscript;
	void Start () {
        Input.simulateMouseWithTouches = true;//touch=click
        mainscript = GameObject.Find("MAIN").GetComponent<MainScript>();
    }

    private void OnTriggerStay2D(Collider2D collision)  //VOIDZONE
    {
            Destroy(gameObject);
            mainscript.lives--;
        mainscript.scoreText.text = "Score: " + mainscript.score.ToString() + " Lives: " + mainscript.lives.ToString();
    }
    void OnMouseDown()//CLICK
    {
        if (!mainscript.pause)
        {
            Destroy(gameObject);
            mainscript.score++;
        }
    }
    private void OnDestroy()
    {
        Instantiate(AnimBlow,gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update () {
        //scoreText.text = score.ToString();
        transform.Translate(0f, mainscript.speed*Time.deltaTime, 0);
    }
}
