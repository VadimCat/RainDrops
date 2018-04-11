using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cloud : MonoBehaviour {

    public Transform spawnTransorm;
    public GameObject Rain, Poison, SnowFlake;
    private MainScript mainscript;
    private IEnumerator coroutine;                               
    float i = 0.5f;
    int type, f=0;

    
    // Use this for initialization
    void Start () {
        i = 0.5f;
        mainscript = GameObject.Find("MAIN").GetComponent<MainScript>();
        coroutine = Spawn(i);
        StartCoroutine(coroutine);                            
    }
    
    // Update is called once per frame
    void Update ()
    {                                                                      

    }
    public IEnumerator Spawn(float delay)     //SPAWN
    {
        while (true)                                                    
        {
            yield return new WaitForSeconds(delay);
            {
                type = Random.Range(0, 100);                               
                if ((type >= 0) && (type <= 60))
                {
                    Instantiate(Rain, spawnTransorm.position + new Vector3((Random.Range(10, 550) - 270) / 100f, 0), Quaternion.identity);
                }
                else if ((type >= 61) && (type <= 80))
                {
                    Instantiate(Poison, spawnTransorm.position + new Vector3((Random.Range(10, 550) - 270) / 100f, 0), Quaternion.identity);
                }
                else if ((type >= 81) && (type <= 100))
                {
                    Instantiate(SnowFlake, spawnTransorm.position + new Vector3((Random.Range(10, 550) - 270) / 100f, 0), Quaternion.identity);
                }
                f++;
                if (f % 10 == 0)
                {
                    delay -= 0.01f;
                    mainscript.speed -= 0.05f;
                }
            }
        }
    }
    
}
