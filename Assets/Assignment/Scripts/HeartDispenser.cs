using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartDispenser : Dispenser
{
    public GameObject heart;
    public Transform tHeart;

    protected override void OnTriggerEnter2D()
    {
        base.OnTriggerEnter2D();
        StartCoroutine(spawnHeart());
    }

    IEnumerator spawnHeart()
    {
        yield return new WaitForSeconds(3);
        Instantiate(heart, tHeart.position, tHeart.rotation);
        yield return null;
    }
}
