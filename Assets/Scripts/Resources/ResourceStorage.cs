using System;
using System.Collections.Generic;
using UnityEngine;

namespace CountrySimulator.Resources
{
    public class ResourceStorage : MonoBehaviour
    {
        public List<Resource> tradableResources = new List<Resource>();
        
        public List<ResourceStack> resourcesInStorage= new List<ResourceStack>();

        void Awake()
        {
            InitializeStorage();
        }
        void InitializeStorage()
        {
            foreach (Resource thisResource in tradableResources) {
                ResourceStack newResourceStack = new ResourceStack(thisResource);
                resourcesInStorage.Add(newResourceStack);
            }
        }
    }
}