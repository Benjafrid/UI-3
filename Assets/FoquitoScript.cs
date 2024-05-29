using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex =-1; //empieza en -1 asi cuando se incrementa 1 empieza en 0 que va a ser un color

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight()
    {
        currentLightIndex++; //incrementa 1
        if (currentLightIndex >= colors.Length) // chequea que no se pase del length, en caso de que se pase vuelve a 0, es decir que vuelve a empezar
        {
            currentLightIndex = 0;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    public void ActivatePreviousLight()
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true); // activa la otra luz
    }

    void DeactivateAllLights()
    {
        foreach (GameObject g in colors) // pasa por todos los elementos del array de forma obligatoria
        {
            g.SetActive(false);
        }
    }

    public void ActivateRepeating(float t)
    {
        InvokeRepeating(nameof(ActivateNextLight),0,t);
    }
}
