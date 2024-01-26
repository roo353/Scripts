using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolsTest : MonoBehaviour
{
    
    public Bools boolData;
    void Start()
    {
         if(boolData.myBool)
        {
            Debug.Log("myBool is true!");
        }
        else
        {
            Debug.Log("myBool is false!");
        }
    }
}
