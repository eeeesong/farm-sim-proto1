using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmManager : MonoBehaviour
{
    public PlantItem selectedPlant;
    public bool isPlanting;

    public void Select(PlantItem newPlant)
    {
        if (selectedPlant == newPlant)
        {
            selectedPlant = null;
            isPlanting = false;
        } else
        {
            selectedPlant = newPlant;
            isPlanting = true;
        }
    }
}
