using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    private bool isPlanted;

    [SerializeField] private Sprite[] plantSprites;
    [SerializeField] private SpriteRenderer plant;

    private int plantStage;
    private float timeBtwStages = 0.5f;
    private float timer;

    private void Update()
    {
        if (isPlanted)
        {
            timer -= Time.deltaTime;

            if (timer < 0 && plantStage < plantSprites.Length - 1)
            {
                plantStage++;
                timer = timeBtwStages;
                UpdatePlant();
            }
        }
    }

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
        plant.gameObject.SetActive(false);
    }

    private void Plant()
    {
        Debug.Log("Planted!");
        isPlanted = true;
        plantStage = 0;
        UpdatePlant();
        plant.gameObject.SetActive(true);
    }

    private void UpdatePlant()
    {
        plant.sprite = plantSprites[plantStage];
    }
}
