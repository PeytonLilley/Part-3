using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDispenser : Dispenser
{
    public GameObject key;
    public Transform tKey;

    protected override void OnTriggerEnter2D()
    {
        base.OnTriggerEnter2D();
        StartCoroutine(spawnKey());
    }

    IEnumerator spawnKey()
    {
        yield return new WaitForSeconds(3);
        Instantiate(key, tKey.position, tKey.rotation);
        yield return null;
    }
}
