using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    private bool isPlanted;
    [SerializeField] private GameObject plant;

    private void OnMouseDown()
    {
        if (isPlanted)
        {
            Harvest();
        } else
        {
            Plant();
        }
    }

    private void Harvest()
    {
        Debug.Log("Harvested!");
        isPlanted = false;
        plant.SetActive(false);
    }

    private void Plant()
    {
        Debug.Log("Planted!");
        isPlanted = true;
        plant.SetActive(true);
    }
}
