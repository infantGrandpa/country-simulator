using TMPro;
using UnityEngine;

namespace CountrySimulator.Cities
{
    public class CityLabelBehaviour : MonoBehaviour
    {
        [SerializeField] TMP_Text cityNameLabel;

        public void SetCityName(string cityName)
        {
            cityNameLabel.text = cityName;
        }
    }
}
