using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    private bool isPlanted;

    private SpriteRenderer plant;
    private PlantObject selectedPlant;
    private BoxCollider2D plantCollider;

    private int plantStage;
    private float timer;

    private FarmManager fm;
    private SpriteRenderer plot;

    private void Start()
    {
        plant = transform.GetChild(0).GetComponent<SpriteRenderer>();
        plantCollider = transform.GetChild(0).GetComponent<BoxCollider2D>();
        fm = FindObjectOfType<FarmManager>();
        plot = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isPlanted)
        {
            timer -= Time.deltaTime;

            if (timer < 0 && plantStage < selectedPlant.plantStages.Length - 1)
            {
                plantStage++;
                timer = selectedPlant.timeBtwStages;
                UpdatePlant();
            }
        }
    }

    private void OnMouseDown()
    {
        if (isPlanted)
        {
            if (plantStage == selectedPlant.plantStages.Length -1)
            {
                Harvest();
            }
        } else if (fm.isPlanting)
        {
            Plant(fm.selectedPlant);
        }
    }

    private void OnMouseOver()
    {
        if (isPlanted)
        {
            plot.color = Color.red;
        } else if (selectedPlant != null)
        {
            plot.color = Color.green;
        }
    }

    private void OnMouseExit()
    {
        plot.color = Color.white;
    }

    private void Harvest()
    {
        isPlanted = false;
        plant.gameObject.SetActive(false);
        fm.Transaction(selectedPlant.price);
    }

    private void Plant(PlantItem newPlant)
    {
        selectedPlant = newPlant.plantData;
        isPlanted = true;
        plantStage = 0;
        UpdatePlant();
        timer = selectedPlant.timeBtwStages;
        plant.gameObject.SetActive(true);
    }

    private void UpdatePlant()
    {
        plant.sprite = selectedPlant.plantStages[plantStage];
        plantCollider.size = plant.sprite.bounds.size;
        plantCollider.offset = new Vector2(0, plant.bounds.size.y / 2);
    }
}
