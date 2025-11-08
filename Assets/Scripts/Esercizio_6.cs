using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio_6 : MonoBehaviour
{
    // Inspector di due valori - Riporta in console il valore più alto
    // Start is called before the first frame update
    [SerializeField] private int Value0;
    [SerializeField] private int Value1;

    void Start()
    {
        int i = Value0;
        int j = Value1;
        if (i > j)
        {
            Debug.Log(i);   
        }
        else if (j > i)
        {
            Debug.Log(j);
        }
        else
        {
            Debug.Log("Sono uguali");
        }
    }
}
// Update is called once per frame