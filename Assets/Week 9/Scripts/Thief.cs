using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifeOne;
    public GameObject knifeTwo;
    public Transform spawnPointOne;
    public Transform spawnPointTwo;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        speed = 5;
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        base.Attack();
        Instantiate(knifeOne, spawnPointOne.position, spawnPointOne.rotation);
        Instantiate(knifeTwo, spawnPointTwo.position, spawnPointTwo.rotation);
    }
}
