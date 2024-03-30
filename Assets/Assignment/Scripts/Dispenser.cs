using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    Animator buttonPress;
    bool button;
    // Start is called before the first frame update
    void Start()
    {
        buttonPress = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("button");
        buttonPress.SetBool("button", true);
    }

    void OnTriggerExit2D()
    {
        Debug.Log("not pressed");
        buttonPress.SetBool("button", false);
    }
}
