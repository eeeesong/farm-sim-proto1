using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmManager : MonoBehaviour
{
    public PlantItem selectedPlant;
    public bool isPlanting;
    public int money;
    public Text moneyText;

    private void Start()
    {
        Transaction(100);
    }

    public void Select(PlantItem newPlant)
    {
        if (selectedPlant == newPlant)
        {
            selectedPlant = null;
            isPlanting = false;
        } else
        {
            int price = newPlant.plantData.price;

            if (money >= price)
            {
                Transaction(-price);
                selectedPlant = newPlant;
                isPlanting = true;
            } else
            {
                Debug.Log("no money!");
            }
        }
    }

    public void Transaction(int amount)
    {
        money += amount;
        moneyText.text = "$" + money;
    }
}
