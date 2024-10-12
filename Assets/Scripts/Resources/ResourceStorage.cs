using System.Collections.Generic;
using Abraham.CountrySimulator.GUI;
using CountrySimulator.Resources;
using UnityEngine;

namespace Abraham.CountrySimulator.Resources
{
    public class ResourceStorage : MonoBehaviour
    {
        public List<Resource> tradableResources = new List<Resource>();
        
        public List<ResourceStack> resourcesInStorage= new List<ResourceStack>();

        [SerializeField] GameObject resourceStorageListPrefab;
        ResourceStorageListBehaviour _storageList;

        void Awake()
        {
            InitializeStorage();
            CreateResourceStorageList();
            
        }
        void InitializeStorage()
        {
            foreach (Resource thisResource in tradableResources) {
                ResourceStack newResourceStack = new ResourceStack(thisResource);
                resourcesInStorage.Add(newResourceStack);
            }
        }

        void CreateResourceStorageList()
        {
            GameObject storageListGameObject = GUIManager.Instance.InstantiateGameObjectOnSpatialCanvas(resourceStorageListPrefab);
            _storageList = storageListGameObject.GetComponent<ResourceStorageListBehaviour>();
            
            _storageList.InitializeLabel(resourcesInStorage, transform.position);
        }
    }
}