using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_8 : MonoBehaviour
{
    // Start is called before the first frame update
    // Voto studente da numerico ad alfabetico stile USA
    [SerializeField] private int VoteValue;
    void Start()
    {
        if (VoteValue < 0 || VoteValue > 10) // Suggerimento appreso durante Labortorio
        {
            Debug.Log("Valore non valido");
        }
        else
        {
            if (VoteValue <= 4)
                Debug.Log("F");
            else if (VoteValue == 5)
                Debug.Log("D");
            else if (VoteValue == 6)
                Debug.Log("C");
            else if (VoteValue == 7 || VoteValue == 8)
                Debug.Log("B");
            else if (VoteValue == 9)
                Debug.Log("A");
            else if (VoteValue == 10)
                Debug.Log("A+");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}