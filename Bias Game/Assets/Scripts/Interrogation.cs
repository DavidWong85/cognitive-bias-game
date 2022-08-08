using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interrogation : MonoBehaviour
{
    public Button button;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON1;
    [SerializeField] private TextAsset inkJSON2;
    [SerializeField] private TextAsset inkJSON3;
    [SerializeField] private TextAsset inkJSON4;

    [Header("Interrogate Status")]
    [SerializeField] private bool interrogated1;
    [SerializeField] private bool interrogated2;
    [SerializeField] private bool interrogated3;
    [SerializeField] private bool interrogated4;

    [Header("LogManager")]
    [SerializeField] public GameObject LogManager;
    [SerializeField] private TextAsset log1;
    [SerializeField] private TextAsset log2;
    [SerializeField] private TextAsset log3;
    [SerializeField] private TextAsset log4;
    [SerializeField] public bool TextCreated1;
    [SerializeField] public bool TextCreated2;
    [SerializeField] public bool TextCreated3;
    [SerializeField] public bool TextCreated4;

    void Awake()
    {
        interrogated1 = false;
        interrogated2 = false;
        interrogated3 = false;
        interrogated4 = false;
    }

    GameObject[] suspects;
    public void interrogation()
    {   
        suspects = GameObject.FindGameObjectsWithTag("Suspect");
        foreach (GameObject target in suspects)
        {
            if (target.GetComponent<Suspect>().interrogating)
            {
                if (target.GetComponent<Suspect>().suspectID == 1)
                {   
                    if (!interrogated1) 
                    {
                        interrogated1 = true;
                        DialogueManager.GetInstance().EnterDialogueMode(inkJSON1);
                        TextCreated1 = true;
                    }
                    else
                    {
                        LogManager.GetComponent<LogManager>().setLog(log1);
                        LogManager.GetComponent<LogManager>().ShowLog();
                    }
                }
                if (target.GetComponent<Suspect>().suspectID == 2)
                {   
                    if (!interrogated2) 
                    {
                        interrogated2 = true;
                        DialogueManager.GetInstance().EnterDialogueMode(inkJSON2);
                        TextCreated2 = true;
                    }
                    else
                    {
                        LogManager.GetComponent<LogManager>().setLog(log2);
                        LogManager.GetComponent<LogManager>().ShowLog();
                    }
                }
                if (target.GetComponent<Suspect>().suspectID == 3)
                {   
                    if (!interrogated3) 
                    {
                        interrogated3 = true;
                        DialogueManager.GetInstance().EnterDialogueMode(inkJSON3);
                        TextCreated3 = true;
                    }
                    else
                    {
                        LogManager.GetComponent<LogManager>().setLog(log3);
                        LogManager.GetComponent<LogManager>().ShowLog();
                    }
                }
                if (target.GetComponent<Suspect>().suspectID == 4)
                {   
                    if (!interrogated4) 
                    {
                        interrogated4 = true;
                        DialogueManager.GetInstance().EnterDialogueMode(inkJSON4);
                        TextCreated4 = true;
                    }
                    else
                    {
                        LogManager.GetComponent<LogManager>().setLog(log4);
                        LogManager.GetComponent<LogManager>().ShowLog();
                    }
                }
            }
        }
    }
}
