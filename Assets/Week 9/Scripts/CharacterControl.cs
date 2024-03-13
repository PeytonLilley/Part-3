using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }
    TextMeshProUGUI typeSelected;

    private void Start()
    {
        typeSelected = GetComponent<TextMeshProUGUI>();
        typeSelected.text = SelectedVillager.GetType().ToString();
       
    }
    public static void SetSelectedVillager(Villager villager)
    {
        if (SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }
}
