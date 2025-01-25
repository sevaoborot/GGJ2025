using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Assets/Random Fill Data")]
public class RandomTextFillersScript : ScriptableObject
{
    [SerializeField] private string[] _randomNames;
    [SerializeField] private string[] _randomUsernames;
    public Dictionary<string, string> NamesAndUsernames = new Dictionary<string, string>();
    public string[] randomText;

    private void OnEnable()
    {
        int numberOfDictionaryElements = 0;
        if (_randomNames.Length != _randomUsernames.Length)  numberOfDictionaryElements = _randomNames.Length < _randomUsernames.Length ? _randomNames.Length : _randomUsernames.Length;
        else numberOfDictionaryElements = _randomNames.Length;
        for (int i = 0; i < numberOfDictionaryElements; i++) NamesAndUsernames.Add(_randomUsernames[i], _randomNames[i]);
        foreach (var name in NamesAndUsernames)
        {
            Debug.Log(name);
        }
    }
}
