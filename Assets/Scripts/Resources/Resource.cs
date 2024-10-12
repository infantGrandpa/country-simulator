using UnityEngine;

namespace Abraham.CountrySimulator.Resources
{
    [CreateAssetMenu(fileName = "New Resource", menuName = "Resource")]
    public class Resource : ScriptableObject
    {
        public string resourceName;
    }
}
