using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabelline : MonoBehaviour
{
    [SerializeField] int numeroTabellina;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i <= 9; i++)   //Ciclo tabelline da 2 a 9
        {
            Debug.Log("tabellina del " + i + ":");
            for (int j = 1; j <= 10; j++)
            {
                int risultato = i * j;
                Debug.Log(i + " x " + j + " = " + risultato);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
