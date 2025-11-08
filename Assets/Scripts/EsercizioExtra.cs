using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Utilizzando un ciclo FOR stampare la tabellina del 5
public class EsercizioExtra : MonoBehaviour
{
    [SerializeField] int NumeroTabellina;
    private int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        {
            {
                for (int i = 1; i <= 10; i++)
                {
                    int risultato = NumeroTabellina * i;
                    Debug.Log(NumeroTabellina + " x " + i + " = " + risultato);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}