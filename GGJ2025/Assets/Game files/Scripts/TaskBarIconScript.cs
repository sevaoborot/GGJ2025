using UnityEngine;

public class TaskBarIconScript : MonoBehaviour
{
    private GameObject _window;

    public void SetWindow(GameObject window)
    {
        if (window != null)
        {
            _window = window;
        }
    }

    public void MaximizeMinimizeWindow()
    {
        if (_window.activeSelf) _window.SetActive(false);
        else if (!_window.activeSelf) _window.SetActive(true);
    }
}
