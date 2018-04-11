using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voidzone : MonoBehaviour {

    // Use this for initialization

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision);
    }
}
