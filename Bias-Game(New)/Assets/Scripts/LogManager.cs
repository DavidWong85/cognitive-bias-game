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
    [SerializeField] private TextAsset log;
    [SerializeField] private GameObject Scrollbar;
    [SerializeField] public bool storyEnded = false;
    
    [SerializeField] private bool ShowingLog = false;

    private void Update()
    {
        /*
        if (ShowingLog == false)
        {
            logPanel.SetActive(false);
        }
        else 
        {
            logPanel.SetActive(true);
            logText.text = log.text;
        }
        */      
        if (ShowingLog == true)
        {
            logPanel.SetActive(true);
            logText.text = log.text;
            if (Scrollbar.GetComponent<Scrollbar>().value > 0 && storyEnded == false)
            {
                Scrollbar.GetComponent<Scrollbar>().value -= 0.0005f;
            }
        }
    }

    public void setLog(TextAsset _log)
    {   
        #if UNITY_EDITOR
        AssetDatabase.Refresh();
        #endif
        log = _log;
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