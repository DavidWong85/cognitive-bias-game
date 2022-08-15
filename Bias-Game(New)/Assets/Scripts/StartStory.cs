using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartStory : MonoBehaviour
{   
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON1;
 
    GameObject[] story;
    public void startStory()
    {
        story = GameObject.FindGameObjectsWithTag("Story");
        foreach (GameObject target in story)
        {
            if (target.GetComponent<story>().storyID == 1)
            {
                StoryManager.GetInstance().EnterStoryMode(inkJSON1);
            } 
        }
    }
}
