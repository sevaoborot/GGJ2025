using UnityEngine;

public class WindowScript : MonoBehaviour
{
    [SerializeField] private GameObject _taskBarIcon;

    private void OnDisable()
    {
        _taskBarIcon.SetActive(false);
    }

    public void CloseWindowButton() => this.gameObject.SetActive(false);

    public void MinimiseWindowButton() //тут подумать как с иконкой в таскбаре поступать
    {
        this.gameObject.SetActive(false);
    }

    public void SetTaskBarIcon(GameObject taskBarIcon)
    {
        if (taskBarIcon != null) _taskBarIcon = taskBarIcon;
        _taskBarIcon.SetActive(true);
        //else exeption прописать
    }
}
