using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textos : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI texto;
    [SerializeField] private TextMeshProUGUI texto2;

    [SerializeField] private Instantiate instancias;
    [SerializeField] private ClickFunction b1;

    [SerializeField] private CodigoBicho bicho1;
    [SerializeField] private CodigoPutrido bicho2;

    [SerializeField] private Rosa flor;

    public int saludenemiga;
    [SerializeField] private int cuentamuertos; 
    void Start()
    {
        saludenemiga = 12;/*instancias.numBichos * (bicho1.health+bicho2.health);*/
        cuentamuertos = 0;
    }

    void Update()
    {
        saludenemiga -= cuentamuertos;//b1.dead;
        texto.text = "Salud enemiga: " + saludenemiga.ToString();
        texto2.text = "Salud rosa: " + flor.health.ToString();
    }
}
