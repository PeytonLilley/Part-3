using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    Animator buttonPress;
    bool button;
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public Transform tCircle1;
    public Transform tCircle2;
    public Transform tCircle3;

//    public Transform dispenser;

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
        StartCoroutine(loadCircles());
    }

    void OnTriggerExit2D()
    {
        Debug.Log("not pressed");
        buttonPress.SetBool("button", false);
    }

    IEnumerator loadCircles()
    {
        yield return StartCoroutine(load1());
        yield return new WaitForSeconds(1);
        yield return StartCoroutine(load2());
        yield return new WaitForSeconds(1);
        yield return StartCoroutine(load3());
        yield return new WaitForSeconds(1);
    }

    IEnumerator load1()
    {
        Debug.Log("load1");
        Instantiate(circle1, tCircle1.position, tCircle1.rotation);      
        yield return null;
    }

    IEnumerator load2()
    {
        Debug.Log("load2");
        Instantiate(circle2, tCircle2.position, tCircle2.rotation);
        yield return null;
    }

    IEnumerator load3()
    {
        Debug.Log("load3");
        Instantiate(circle3, tCircle3.position, tCircle3.rotation);
        yield return null;
    }
}
