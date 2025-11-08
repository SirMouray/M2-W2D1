using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    // Start is called before the first frame update
    // Variabile "StartingNumber" esposta in Inspector
    // Riportare in console i due numeri successivi a "StartingNumber"
    // Start is called before the first frame update

    [SerializeField] private int StartingNumber;
    void Start()
    {
        Debug.Log(StartingNumber + 1);
        Debug.Log(StartingNumber + 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}