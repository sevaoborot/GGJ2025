using UnityEngine;

public class IconScript : MonoBehaviour
{
    [SerializeField] private GameObject _appWindow;
    [SerializeField] private GameObject _appTaskBarIcon;

    private WindowScript _windowScript;

    private void OnEnable()
    {
        _windowScript = _appWindow.GetComponent<WindowScript>();
    }

    public void RunWindow()
    {
        _appWindow.SetActive(true);
        _windowScript.SetTaskBarIcon(_appTaskBarIcon);
        _appTaskBarIcon.SetActive(true);
    }
}
