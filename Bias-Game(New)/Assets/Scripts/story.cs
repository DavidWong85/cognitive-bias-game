using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class story : MonoBehaviour
{
    [Header("story")]
    [SerializeField] public int storyID;

    public bool TextCreated;

    public void CreateStoryLog()
    {
        TextCreated = true; 
    }
} 