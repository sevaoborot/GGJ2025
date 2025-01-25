using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BasicBlockScript : MonoBehaviour
{
    private Image _backgroundImage;
    private Color[] _color =
    {
        Color.cyan,
        Color.magenta,
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow
    };

    private TextMeshProUGUI _accountName;
    private TextMeshProUGUI _userName;
    private TextMeshProUGUI _messageText;
    [SerializeField] private Image _userpic;

    [Header("Settings")]
    [SerializeField] private RandomTextFillersScript _textFillers;

    private void OnEnable()
    {
        TextMeshProUGUI[] textElements = this.GetComponentsInChildren<TextMeshProUGUI>();
        _accountName = textElements[0];
        _userName = textElements[1];    
        _messageText = textElements[2];
        Image[] images = this.GetComponentsInChildren<Image>();
        _backgroundImage = images[0];
        _userpic = images[1];

        NamesAndUsernames nameAndUsername = _textFillers.namesAndUsernames[Random.Range(0, _textFillers.namesAndUsernames.Count)];
        _accountName.text = nameAndUsername.name;
        _userName.text = nameAndUsername.username;
        _messageText.text = _textFillers.randomText[Random.Range(0, _textFillers.randomText.Length)];
        _userpic.sprite = _textFillers.userpics[Random.Range(0, _textFillers.userpics.Length)];

        //_backgroundImage = this.GetComponent<Image>();
        _backgroundImage.color = _color[Random.Range(0, _color.Length)];
    }
}
