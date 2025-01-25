using UnityEngine;
using UnityEngine.UI;

public class NewMessagesScript : MonoBehaviour
{
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private Transform contentTransform; 
    [SerializeField] private ScrollRect scrollRect;     

    public void AddItem()
    {
        GameObject newItem = Instantiate(itemPrefab, contentTransform);
        newItem.transform.SetSiblingIndex(0);
        ScrollToBottom();
    }

    private void ScrollToBottom()
    {
        Canvas.ForceUpdateCanvases(); 
        scrollRect.verticalNormalizedPosition = 0; 
    }
}
