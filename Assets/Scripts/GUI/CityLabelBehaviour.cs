
using TMPro;
using UnityEngine;

namespace Abraham.CountrySimulator.GUI
{
    public class CityLabelBehaviour : MonoBehaviour
    {
        [SerializeField] TMP_Text cityNameLabel;
        [SerializeField] Vector2 labelOffset;

        RectTransform _rectTransform;

        public void InitializeLabel(string cityName, Vector3 worldPosition)
        {
            _rectTransform = GetComponent<RectTransform>();
            
            SetCityName(cityName);
            SetLabelPosition(worldPosition);
        }
        void SetLabelPosition(Vector3 worldPosition)
        {
            Vector2 canvasPosition = GUIManager.Instance.mainCanvas.WorldToCanvasPosition(worldPosition, GUIManager.Instance.mainCamera);
            Vector2 finalPosition = canvasPosition + labelOffset;

            _rectTransform.anchoredPosition = finalPosition;
        }

        void SetCityName(string cityName)
        {
            cityNameLabel.text = cityName;
        }
    }
}
