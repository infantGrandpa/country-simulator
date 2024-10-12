using CountrySimulator.Resources;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Abraham.CountrySimulator.GUI
{
    public class ResourceStorageListItemBehaviour : MonoBehaviour
    {
        public ResourceStack myResourceStack;
        [SerializeField] TMP_Text resourceLabel;
        [SerializeField] TMP_Text resourceValue;

        public void InitializeListItem(ResourceStack newResourceStack)
        {
            myResourceStack = newResourceStack;
            resourceLabel.text = myResourceStack.resource.resourceName;
            resourceValue.text = myResourceStack.amount.ToString();
        }
    }
}
