using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicButton : MonoBehaviour
{   
    public GameObject logManager;
    public Button button;

    public void Awake()
    {   
        logManager = GameObject.FindWithTag("LogManager");
        button.onClick.AddListener(logManager.GetComponent<LogManager>().HideLog);
        button.GetComponent<Interrogation>().LogManager = logManager;

        //Add inkJson 1 - 4 to the button.
        
    }
}
