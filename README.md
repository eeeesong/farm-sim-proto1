# farm-sim-proto1

### Memo...

#### Load resources


```csharp
var loadPlants = Resources.LoadAll("Plants", typeof(PlantObject));
```

Load all objects in `Assets/Resources/Plants`


#### Sort

```csharp
plantObjects.Sort(SortByPrice);

    private int SortByPrice(PlantObject plant1, PlantObject plant2)
    {
        return plant1.price.CompareTo(plant2.price);
    }
```

Write sort rule in int return method, and use it as param




https://github.com/eeeesong/farm-sim-proto1/assets/72188416/e1edcba7-68de-493e-b57f-dfd07d48a2f2


