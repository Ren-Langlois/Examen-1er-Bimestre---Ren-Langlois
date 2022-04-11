using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    int Gcomida = 300;
    int PPcomida = 400;
    int PGcomida = 700;

    public string codeanimal;
    public int dias;

    // Start is called before the first frame update
    void Start()
    {
        if (codeanimal == "G")
        {
            int comidatotal = Gcomida * dias;
            Debug.Log("Para ese periodo se necesitan " +comidatotal+" gramos de comida" );
            int costo = comidatotal / 100 * 80;
            Debug.Log("Costaría "+costo);
        }
        else if (codeanimal == "PP")
        {
            int comidatotal = PPcomida * dias;
            Debug.Log("Para ese periodo se necesitan " + comidatotal + " gramos de comida");
            int costo = comidatotal / 100 * 80;
            Debug.Log("Costaría " + costo);
        }
        else if (codeanimal == "PG")
        {
            int comidatotal = PGcomida * dias;
            Debug.Log("Para ese periodo se necesitan " + comidatotal + " gramos de comida");
            int costo = comidatotal / 100 * 80;
            Debug.Log("Costaría " + costo);
        }
        else if (dias < 3)
        {
            Debug.Log("ERROR: No se pueden menos de 3 dias");
        }
        else
        {
            Debug.Log("ERROR: El codigo es invalido");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
