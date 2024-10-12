using System.Collections.Generic;
using Abraham.CountrySimulator.Resources;
using UnityEngine;

namespace Abraham.CountrySimulator.GUI
{
    public class ResourceStorageListBehaviour : MonoBehaviour
    {
        [SerializeField] GameObject resourceStorageListItemPrefab;
        [SerializeField] Vector2 labelOffset;
        [SerializeField] float rowHeight = 20;
        
        RectTransform _rectTransform;
        
        List<ResourceStorageListItemBehaviour> _resourceStorageListItems = new List<ResourceStorageListItemBehaviour>();

        public void InitializeLabel(List<ResourceStack> resourceStacks, Vector3 worldPosition)
        {
            _rectTransform = GetComponent<RectTransform>();
            
            CreateResourceListItems(resourceStacks);
            SetLabelPosition(worldPosition);
            SetListHeight();
        }
        
        void SetLabelPosition(Vector3 worldPosition)
        {
            Vector2 canvasPosition = GUIManager.Instance.mainCanvas.WorldToCanvasPosition(worldPosition, GUIManager.Instance.mainCamera);
            Vector2 finalPosition = canvasPosition + labelOffset;

            _rectTransform.anchoredPosition = finalPosition;
        }

        void SetListHeight()
        {
            float listWidth = _rectTransform.sizeDelta.x;
            float listHeight = rowHeight * _resourceStorageListItems.Count;
            _rectTransform.sizeDelta = new Vector2(listWidth, listHeight);
        }

        void CreateResourceListItems(List<ResourceStack> resourceStacks)
        {
            foreach (ResourceStack thisResourceStack in resourceStacks) {
                GameObject newListItemGameObject = Instantiate(resourceStorageListItemPrefab, transform);
                ResourceStorageListItemBehaviour newListItem = newListItemGameObject.GetComponent<ResourceStorageListItemBehaviour>();

                if (newListItem == null) {
                    Debug.LogError("ERROR ResourceStorageListBehaviour CreateResourceListItems(): Storage List Item Prefab (" + resourceStorageListItemPrefab.name + ") is missing a ResourceStorageListItemBehaviour component.", this);
                    return;
                }

                newListItem.InitializeListItem(thisResourceStack);
                _resourceStorageListItems.Add(newListItem);
            }
        }
    }
}
