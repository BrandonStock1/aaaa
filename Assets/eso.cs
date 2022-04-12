using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eso : MonoBehaviour
{
    public int pesos;

    // Start is called before the first frame update
    void Start()
    {
        int dolares;
        dolares = pesos / 200;

        if (dolares >= 3)
        {
            Debug.Log("El valor en pesos es mayor a 10 dolares");
        }
        else if (dolares == 2)
        {
            Debug.Log("El valor en pesos es el minimo para poder hacer un withdraw");
        }
        else
        {
            Debug.Log("El valor en pesos es muy bajo para poder hacer un withdraw");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
