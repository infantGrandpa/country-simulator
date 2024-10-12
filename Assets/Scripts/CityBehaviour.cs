using Sirenix.OdinInspector;
using UnityEngine;

public class CityBehaviour : MonoBehaviour
{
    [ReadOnly] public string cityName;

    void Start()
    {
        cityName = CityNameManager.Instance.GetRandomCityName();
    }
}
