using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Suspect : MonoBehaviour
{   
    

    [Header("Interrogated")]
    //[SerializeField] private bool interrogated;
    [SerializeField] public bool interrogating;
    [SerializeField] public int suspectID;

    public bool TextCreated;

    [Header("Name Panel")]
    [SerializeField] private GameObject namePanel;
    [SerializeField] private TextMeshProUGUI nameText;

    private void Awake()
    {
        interrogating = false;
    }

    public void Interrogate()
    {   
        StopInterrogate();
        interrogating = true;
        namePanel.SetActive(true);
        nameText.text = this.name;
        TextCreated = true;
    }
    
    GameObject[] suspects;
    public void StopInterrogate()
    {   
        suspects = GameObject.FindGameObjectsWithTag("Suspect");
        foreach (GameObject target in suspects)
        {
            target.GetComponent<Suspect>().interrogating = false;
        }
        namePanel.SetActive(false);
    }
}
