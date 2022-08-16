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
    
    [SerializeField] private bool ShowingLog = false;

    private void Update()
    {
        if (ShowingLog == false)
        {
            logPanel.SetActive(false);
        }
        else 
        {
            logPanel.SetActive(true);
            logText.text = log.text;
        }
    }

    public void setLog(TextAsset _log)
    {   
        AssetDatabase.Refresh();
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