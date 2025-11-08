using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public float VariabileA;
    public float VariabileB;
    public float VariabileC;
    public float VariabileD;

    // Inserire i numeri da calcolare "Variabili da A a D"

    void Start()
    {
        float somma = VariabileA + VariabileB + VariabileC + VariabileD;

        float moltiplicazione = VariabileA * VariabileB * VariabileC * VariabileD;

        float media = media = somma / 4;

        Debug.Log("la somma dei numeri e':" + somma);
        Debug.Log("la moltiplicazione dei numeri e':" + moltiplicazione);
        Debug.Log("la media dei numeri e':" + media);
    }

    // Update is called once per frame

    void Update()
    {
        
    }
}
