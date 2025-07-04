using System;
using UnityEngine;

//[ExecuteAlways]
public class WeatherController : MonoBehaviour
{
    //Referencias
    public Light ambientLight;
    public Animator animatorManager;

    //Variables
    private int currentWeather = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            // DEBUG QUITAR AL IMPLEMENTAR EN TRONCO
            updateWeather();
        }
    }

    //Setters de ambiente.

    void updateWeather()
    {
        currentWeather++;
        currentWeather %= 3;
        //Debug.Log(currentWeather);
        animatorManager.SetInteger("weatherState", currentWeather);
    }
}
