using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    // Start is called before the first frame update
    // Inspector per StartingNumber e mostrare i due numeri precedenti
    [SerializeField] private int StartingNumber;
    void Start()
    {
        Debug.Log(StartingNumber);
        Debug.Log(StartingNumber - 1);
        Debug.Log(StartingNumber - 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
