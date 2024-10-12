using UnityEngine;

namespace Abraham.CountrySimulator.GUI
{
    public class GUISpatialHandler : MonoBehaviour
    {
        public GameObject InstantiateGameObjectOnSpatialCanvas(GameObject gameObjectToAdd)
        {
             GameObject newInstance = Instantiate(gameObjectToAdd, transform);
             return newInstance;
        }
    }
}
