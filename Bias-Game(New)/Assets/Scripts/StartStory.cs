using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartStory : MonoBehaviour
{   
    [Header("Ink JSON")]
    [SerializeField] public TextAsset inkJSON;
    [SerializeField] public TextAsset inkJSONQuestion;
 
    GameObject[] story;
    public void startStory()
    {
        story = GameObject.FindGameObjectsWithTag("Story");
        foreach (GameObject target in story)
        {
            if (target.GetComponent<story>().storyID == 1)
            {
                StoryManager.GetInstance().EnterStoryMode(inkJSON);
                //StoryManager.GetInstance().EnterQuestionMode(inkJSONQuestion);
            } 
        }
    }

    public TextAsset getStory()
    {
        story = GameObject.FindGameObjectsWithTag("Story");
        foreach (GameObject target in story)
        {
            if (target.GetComponent<story>().storyID == 1)
            {   
                Debug.Log("Got Story");
                return inkJSON;
            }
        }
        return null;
    }
}
