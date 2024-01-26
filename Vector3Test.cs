using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Test : MonoBehaviour
{
    public Vector3 vector3Data;

    private void Start()
    {
        Debug.Log("Vector3 value: " + vector3Data.vector3Value);
    }
}
