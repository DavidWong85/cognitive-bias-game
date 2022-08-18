using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class LogManager : MonoBehaviour
{
    [Header("Text UI")]
    [SerializeField] private GameObject logPanel;
    [SerializeField] private TextMeshProUGUI logText;
    [SerializeField] private GameObject Scrollbar;
    [SerializeField] public bool storyEnded = false;
    [SerializeField] private bool ShowingLog = false;
    

    private void Update()
    {   
        if (ShowingLog == true)
        {
            logPanel.SetActive(true);
        }
    }

    public void StoryMode()
    {
        RectTransform rt = logPanel.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(1600, -350);
    }

    public void LogMode()
    {
        RectTransform rt = logPanel.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(900, -10);
        Scrollbar.GetComponent<Scrollbar>().value = 1;
    }

    public void addLog(string log)
    {
        logText.text += log + "\n";
        Scrollbar.GetComponent<Scrollbar>().value = 0;
    }

    public void ShowLog()
    {
        ShowingLog = true;
    }

    public void HideLog()
    {
        ShowingLog = false;
    }
}