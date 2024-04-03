using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject plantItem;
    private List<PlantObject> plantObjects = new List<PlantObject>();

    private void Awake()
    {
        var loadPlants = Resources.LoadAll("Plants", typeof(PlantObject));

        foreach(var plant in loadPlants)
        {
            plantObjects.Add((PlantObject)plant);
        }

        plantObjects.Sort(SortByPrice);

        foreach(var plant in plantObjects)
        {
            PlantItem newPlantItem = Instantiate(plantItem, transform).GetComponent<PlantItem>();
            newPlantItem.plantData = plant;
        }
    }
   
    private int SortByPrice(PlantObject plant1, PlantObject plant2)
    {
        return plant1.price.CompareTo(plant2.price);
    }
}
