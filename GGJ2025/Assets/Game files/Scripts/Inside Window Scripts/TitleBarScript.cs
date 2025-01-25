using UnityEngine;

public class TitleBarScript : MonoBehaviour
{
    private WindowScript _window;

    private Vector3 _firstMousePosition;
    private Vector3 _deltaDistance;
    private Camera _mainCamera;

    private void OnEnable()
    {
        _window = this.GetComponentInParent<WindowScript>();
        _mainCamera = Camera.main;
    }

    public void WindowSelected()
    {
        _firstMousePosition = GetWorldPoint(Input.mousePosition);
    }

    public void DeltaPosition()
    {
        Vector3 newMousePosition = GetWorldPoint(Input.mousePosition);
        _deltaDistance = newMousePosition - _firstMousePosition;
        _firstMousePosition = newMousePosition;
        _window.MoveWindow(_deltaDistance);
    }

    private Vector3 GetWorldPoint(Vector3 screenPosition)
    {
        screenPosition.z = _mainCamera.nearClipPlane;
        return _mainCamera.ScreenToWorldPoint(screenPosition);
    }
}