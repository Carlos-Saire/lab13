using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using UnityEngine.UIElements;

public class Generar_Enemigos : MonoBehaviour
{
    public GameObject enemigos;
    float Tiempo = 2;
    float TiempoIncial = 0;
    private void Update()
    {
        TiempoIncial += Time.deltaTime;
        if (Tiempo <= TiempoIncial)
        {

            GenerarEnemigo();
            TiempoIncial = 0;
        }
    }

    void GenerarEnemigo()
    {
        Vector2 posicionAleatoria = new Vector2(Random.Range(-7.8f, 7.97f), 8.05f);
        Instantiate(enemigos, posicionAleatoria, transform.rotation);
    }
}
