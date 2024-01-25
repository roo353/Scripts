using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingAnimals : MonoBehaviour
{
    public Animals animals;

    void Start()
    {
        Debug.Log(animals.animal);
        Debug.Log(animals.scientificName);
        Debug.Log(animals.averageWeight);
        Debug.Log(animals.averageHeight);
    }
}
