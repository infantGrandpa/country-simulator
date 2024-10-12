using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CityNameManager : MonoBehaviour
{
    public static CityNameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(CityNameManager)) as CityNameManager;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    private static CityNameManager _instance;
    
    public class CityNames
    {
        public string[] cityNames;      //This MUST be the same name as the name in our json file

        public static CityNames CreateFromJson(string jsonString)
        {
            return JsonUtility.FromJson<CityNames>(jsonString);
        }
    }

    CityNames _cityNames;
    
    void Awake()
    {
        LoadCityNames();
    }
    void LoadCityNames()
    {
        TextAsset jsonText = Resources.Load<TextAsset>("cityNames");
        _cityNames = CityNames.CreateFromJson(jsonText.text);
    }

    public string GetRandomCityName()
    {
        if (_cityNames == null || _cityNames.cityNames.Length <= 0) {
            Debug.LogError("ERROR CityNameManager GetRandomCityName(): City Names is empty!", this);
            return "City Name";
        }

        int randomIndex = Random.Range(0, _cityNames.cityNames.Length);
        return _cityNames.cityNames[randomIndex];
    }
}
