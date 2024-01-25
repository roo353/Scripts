using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingDessert : MonoBehaviour
{
    public DessertCount dessertCount;
    void Start()
    {
        Debug.Log(dessertCount.cookie);
        Debug.Log(dessertCount.cupcake);
        Debug.Log(dessertCount.icecream);
        Debug.Log(dessertCount.muffin);
    }
}
