using System;
using UnityEngine;

namespace CountrySimulator.GUI
{
    public class SpatialCanvasManager : MonoBehaviour
    {
        public static SpatialCanvasManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType(typeof(SpatialCanvasManager)) as SpatialCanvasManager;

                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        private static SpatialCanvasManager _instance;

        
        public GameObject AddGameObjectToSpatialCanvas(GameObject gameObjectToAdd)
        {
             GameObject newInstance = Instantiate(gameObjectToAdd, transform);
             return newInstance;
        }
    }
}
