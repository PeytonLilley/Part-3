using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemDispenser : Dispenser
{
    public GameObject gem;
    public Transform tGem;

    protected override void OnTriggerEnter2D()
    {
        base.OnTriggerEnter2D();
        StartCoroutine(spawnGem());
    }

    IEnumerator spawnGem()
    {
        yield return new WaitForSeconds(3);
        Instantiate(gem, tGem.position, tGem.rotation);
        yield return null;
    }
}
