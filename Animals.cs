using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Test", menuName = "TestScriptableObject")]
public class Animals : ScriptableObject
{
    public string animal;
    public string scientificName;

    public float averageHeight;
    public float averageWeight;
}
