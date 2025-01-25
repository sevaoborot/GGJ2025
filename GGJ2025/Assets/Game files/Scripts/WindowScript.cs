using UnityEngine;

public class WindowScript : MonoBehaviour
{
    private GameObject _taskBarIcon;

    public void CloseWindowButton()
    {
        this.gameObject.SetActive(false);
        _taskBarIcon.SetActive(false);
    }

    public void MinimiseWindowButton() //тут подумать как с иконкой в таскбаре поступать
    {
        this.gameObject.SetActive(false);
    }

    public void SetTaskBarIcon(GameObject taskBarIcon)
    {
        if (taskBarIcon != null)
        {
            _taskBarIcon = taskBarIcon;
            _taskBarIcon.SetActive(true);
            _taskBarIcon.GetComponent<TaskBarIconScript>().SetWindow(this.gameObject);
        }
        //else exeption прописать
    }
}
