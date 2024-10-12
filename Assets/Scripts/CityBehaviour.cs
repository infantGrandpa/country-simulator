using System;
using UnityEngine;

public class CityBehaviour : MonoBehaviour
{
    public string cityName;

    void Start()
    {
        cityName = CityNameManager.Instance.GetRandomCityName();
    }
}
