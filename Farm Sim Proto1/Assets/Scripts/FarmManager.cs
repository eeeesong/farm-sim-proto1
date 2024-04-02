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
            newPlant.buttonImage.color = Color.green;
            newPlant.buttonText.text = "Buy";
        } else
        {
            int price = newPlant.plantData.price;

            if (money >= price)
            {
                if (selectedPlant != null)
                {
                    selectedPlant.buttonImage.color = Color.green;
                    selectedPlant.buttonText.text = "Buy";
                }

                Transaction(-price);
                selectedPlant = newPlant;
                isPlanting = true;

                selectedPlant.buttonImage.color = Color.red;
                selectedPlant.buttonText.text = "Cancel";
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
