using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantItem : MonoBehaviour
{
    public PlantObject plantData;

    [SerializeField] private Text nameText;
    [SerializeField] private Text priceText;
    [SerializeField] private Image icon;

    public Image buttonImage;
    public Text buttonText;

    private FarmManager fm;

    void Start()
    {
        nameText.text = plantData.name;
        priceText.text = "$" + plantData.price.ToString();
        icon.sprite = plantData.plantIcon;

        fm = FindObjectOfType<FarmManager>();
    }

    public void Buy()
    {
        fm.Select(this);
    }
}
