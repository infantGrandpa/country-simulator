using UnityEngine;
using Sirenix.OdinInspector;

namespace Abraham.CountrySimulator.GUI
{
    public class GUIManager : MonoBehaviour
    {
        public static GUIManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType(typeof(GUIManager)) as GUIManager;

                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        private static GUIManager _instance;
        
        [ReadOnly] public Canvas mainCanvas;
        [ReadOnly] public Camera mainCamera;
        
        [Header("Spatial Elements")] [SerializeField]
        GUISpatialHandler spatialHandler;
        
        private void Awake()
        {
            mainCanvas = GetComponent<Canvas>();
            mainCamera = Camera.main;
        }
        
        public GameObject InstantiateGameObjectOnSpatialCanvas(GameObject gameObjectToAdd)
        {
            return spatialHandler.InstantiateGameObjectOnSpatialCanvas(gameObjectToAdd);
        }
    }
}
