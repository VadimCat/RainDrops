using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour {
    public GameObject AnimBlow;
    private IEnumerator FreezeScr;
    private MainScript mainscript;

    void Start()
    {
        Input.simulateMouseWithTouches = true;//touch=click
        mainscript = GameObject.Find("MAIN").GetComponent<MainScript>();
    }
    

    private void OnTriggerStay2D(Collider2D collision)  //VOIDZONE
    {
        Destroy(gameObject);
    }


    void OnMouseDown()//CLICK
    {
        if (!mainscript.pause)
        {
            mainscript.StartCoroutine(mainscript.FRZ());
            Destroy(gameObject); 
        }
    }


    private void OnDestroy()
    {
        Instantiate(AnimBlow, gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame


    void Update()
    {
        //scoreText.text = score.ToString();
        transform.Translate(0f, mainscript.speed* 2 * Time.deltaTime, 0);
    }

}
