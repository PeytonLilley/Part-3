using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
}
