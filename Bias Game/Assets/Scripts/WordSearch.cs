using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class WordSearch : MonoBehaviour
{
    public Button button;
    public TMP_InputField inputField;
    string userInput;
    [SerializeField] private GameObject KeywordPanel;
    [SerializeField] private GameObject logPanel;
    [SerializeField] private TextMeshProUGUI log;
    [SerializeField] private TextAsset Keywords;

    public GameObject ButtonPrefab;

    public List<string> keywordList = new List<string>();

    public void SearchWords()
    {   
        if (logPanel.activeSelf != true)
        {
            Debug.Log("Not Viewing Log.");
            return;
        }
        userInput = inputField.text;
        string[] words = userInput.Split(' ');
        foreach (string word in words)
        {
            if (word == "")
            {
                Debug.Log("Invalid Input.");
                return;
            }
            string pattern = "\\b" + word + "\\b";
            if (Regex.Match(log.text, pattern, RegexOptions.IgnoreCase).Success)
            {
                if (Regex.Match(Keywords.text, pattern, RegexOptions.IgnoreCase).Success)
                {
                    if (keywordList.Contains(word) == false)
                    {
                        Debug.Log(word + " Is a Keyword");
                        keywordList.Add(word);
                        //Create Buttons if it is a keyword
                        GameObject newButton = Instantiate(ButtonPrefab) as GameObject;
                        newButton.name = word;
                        newButton.transform.SetParent(KeywordPanel.transform);
                        newButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = word;
                        newButton.transform.localScale= new Vector3(1,1,1);
                    }
                    else 
                    {
                        Debug.Log(word + " Already Found."); 
                    }
                }
                else
                {
                    Debug.Log(word + " Is Not A Keyword");
                }
            }
            else
            {
                Debug.Log("Could not find " + word);
            }
        }
    }
}
