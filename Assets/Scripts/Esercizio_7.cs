using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_7 : MonoBehaviour
{
    // Start is called before the first frame update
    // Inspector di due valori - Riporta in console il valore più alto
    [SerializeField] private int Value0;
    [SerializeField] private int Value1;

    void Start()
    {
        int i = Value0;
        int j = Value1;
        if (i > j)
            Debug.Log(j);
        else if (j > i)
        {
            Debug.Log(i);
        }
        else
        {
            Debug.Log("Sono uguali");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
