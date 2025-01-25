using UnityEngine;
using UnityEngine.UI;

public class NewMessagesScript : MonoBehaviour
{
    [SerializeField] private GameObject _itemPrefab;
    [SerializeField] private Transform _contentTransform; 
    [SerializeField] private ScrollRect _scrollRect;

    public void AddBasicBlock()
    {
        GameObject newItem = Instantiate(_itemPrefab, _contentTransform);
        newItem.transform.SetSiblingIndex(0);
        ScrollToBottom();
    }

    public void AddStoytellingBlock()
    {

    }

    private void ScrollToBottom()
    {
        Canvas.ForceUpdateCanvases(); 
        _scrollRect.verticalNormalizedPosition = 0; 
    }
}
