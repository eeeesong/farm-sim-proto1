using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plant", menuName = "Plant")]
public class PlantObject : ScriptableObject
{
    public string name;
    public int price;
    public Sprite[] plantStages;
    public float timeBtwStages;
    public Sprite plantIcon;
}
