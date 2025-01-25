using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Assets/Random Fill Data")]
public class RandomTextFillersScript : ScriptableObject
{
    [SerializeField] private string[] _randomNames;
    [SerializeField] private string[] _randomUsernames;

    public List<NamesAndUsernames> namesAndUsernames = new List<NamesAndUsernames>();
    public string[] randomText; //сделать защиту от идиотов
    public Sprite[] userpics;

    private void OnEnable()
    {
        int numberOfDictionaryElements = 0;
        if (_randomNames.Length != _randomUsernames.Length)  numberOfDictionaryElements = _randomNames.Length < _randomUsernames.Length ? _randomNames.Length : _randomUsernames.Length;
        else numberOfDictionaryElements = _randomNames.Length;
        for (int i = 0; i < numberOfDictionaryElements; i++)
        {
            namesAndUsernames.Add(new NamesAndUsernames(_randomNames[i], _randomUsernames[i]));
        }
        Debug.Log(namesAndUsernames.Count);
    }
}

public struct NamesAndUsernames
{
    public string name { get; private set; }
    public string username { get; private set; }

    public NamesAndUsernames(string name = "Tom", string username = "@tom")
    {
        this.name = name;
        this.username = username;
    }
}
