using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
//Il numero e' pari o dispari?
{
    [SerializeField] private int ValueA;
    // Start is called before the first frame update
    void Start()
    {
        int Result = ValueA % 2;
            Debug.Log("Il numero e'" + ValueA);
        if (Result == 0)
            Debug.Log("Il numero e' pari");
        else
            Debug.Log("Il numero e' dispari");
    }
    // Update is called once per frame
    void Update()
    {
    }
}