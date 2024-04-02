using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantItem : MonoBehaviour
{
    [SerializeField] private PlantObject plantData;

    [SerializeField] private Text nameText;
    [SerializeField] private Text priceText;
    [SerializeField] private Image icon;

    void Start()
    {
        nameText.text = plantData.name;
        priceText.text = "$" + plantData.price.ToString();
        icon.sprite = plantData.plantIcon;
    }

    public void Buy()
    {
        Debug.Log("Buy" + plantData.name);
    }
}
