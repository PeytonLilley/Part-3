using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle1 : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
}
