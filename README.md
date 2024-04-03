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
