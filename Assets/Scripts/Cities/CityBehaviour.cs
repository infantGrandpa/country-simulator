using Abraham.CountrySimulator.GUI;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Abraham.CountrySimulator.Cities
{
    public class CityBehaviour : MonoBehaviour
    {
        [ReadOnly] public string cityName;

        [SerializeField] GameObject cityLabelPrefab;
        CityLabelBehaviour _myCityLabel;
        
        void Start()
        {
            cityName = CityNameManager.Instance.GetRandomCityName();
            CreateCityLabel();
        }
        
        void CreateCityLabel()
        {
            if (!cityLabelPrefab) {
                Debug.LogWarning("CityBehaviour CreateCityLabel(): CityLabelPrefab is null.", this);
                return;
            }
            
            GameObject labelGameObject = GUIManager.Instance.InstantiateGameObjectOnSpatialCanvas(cityLabelPrefab);
            _myCityLabel = labelGameObject.GetComponent<CityLabelBehaviour>();

            if (_myCityLabel == null) {
                Debug.LogWarning("CityBehaviour CreateCityLabel(): CityLabelPrefab (" + labelGameObject.name +") does not have a CityLabelBehaviour component.", this);
                return;
            }
            
            _myCityLabel.InitializeLabel(cityName, transform.position);

        }
    }
}
