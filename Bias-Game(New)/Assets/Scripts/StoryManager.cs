using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using System.IO;

public class StoryManager : MonoBehaviour
{
    [Header("Story UI")]
    [SerializeField] private GameObject storyPanel;
    [SerializeField] private TextMeshProUGUI storyText;
    [SerializeField] private GameObject continueButton;

    [Header("Question UI")]
    [SerializeField] private GameObject questionPanel;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private GameObject continueQuestion;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    [SerializeField] private GameObject[] questionChoices;
    private TextMeshProUGUI[] choicesText;
    private TextMeshProUGUI[] questionChoicesText;

    [Header("Story")]
    [SerializeField] private GameObject story;
    
    [Header("LogManager")]
    [SerializeField] private GameObject LogManager;

    private Story currentStory;

    public bool storyIsPlaying { get; private set; }

    private string path;

    private static StoryManager instance;

    private bool QuestionMode;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of StoryManager found!");
        }
        instance = this;
    }

    public static StoryManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {   
        storyIsPlaying = false;
        QuestionMode = false;
        storyPanel.SetActive(false);
        questionPanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }

        questionChoicesText = new TextMeshProUGUI[questionChoices.Length];
        int questionindex = 0;
        foreach(GameObject questionChoice in questionChoices)
        {
            questionChoicesText[questionindex] = questionChoice.GetComponentInChildren<TextMeshProUGUI>();
            questionindex++;
        }
    }

    private void Update()
    {
        if (!storyIsPlaying)
        {
            return;
        }
    }

    public void EnterStoryMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        storyIsPlaying = true;
        storyPanel.SetActive(true);

        ContinueStory();
    }

    public void EnterQuestionMode(TextAsset inkJSON)
    {
        QuestionMode = true;
        currentStory = new Story(inkJSON.text);
        questionPanel.SetActive(true);

        ContinueQuestion();
    }

    private IEnumerator ExitStoryMode()
    {   
        yield return new WaitForSeconds(0.1f);

        storyPanel.SetActive(false);
        LogManager.GetComponent<LogManager>().storyEnded = true;
        continueButton.SetActive(false);
        continueQuestion.SetActive(false);
        storyText.text = "";
        LogManager.GetComponent<LogManager>().LogMode();
        if (QuestionMode == true)
        {   
            Debug.Log("Finished");
            storyIsPlaying = false;
        }
        else
        {
            EnterQuestionMode(story.GetComponent<StartStory>().inkJSONQuestion);
        }
    }

    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            storyText.text = currentStory.Continue();
            //Output text using log manager
            LogManager.GetComponent<LogManager>().addLog(storyText.text);
            DisplayChoices();
        }
        else 
        {
            StartCoroutine(ExitStoryMode());
        }
    }

    public void ContinueQuestion()
    {
        if (currentStory.canContinue)
        {
            questionText.text = currentStory.Continue();
            DisplayChoices();
        }
        else 
        {   
            StartCoroutine(ExitStoryMode());
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: " + currentChoices.Count);
        }

        if (currentChoices.Count > 0)
        {   
            if (QuestionMode != true)
            {
                continueButton.SetActive(false);
            }
            else
            {
                continueQuestion.SetActive(false);
            }
            
        }
        else
        {   
            if (QuestionMode != true)
            {
                continueButton.SetActive(true);
            }
            else
            {
                continueQuestion.SetActive(true);
            }
            
        }

        if (QuestionMode != true)
        {
            int index = 0;
            foreach(Choice choice in currentChoices)
            {
                choices[index].gameObject.SetActive(true);
                choicesText[index].text = choice.text;
                index++;
            }
            for (int i = index; i < choices.Length; i++)
            {
                choices[i].gameObject.SetActive(false);
            }
        }
        else
        {
            int index = 0;
            foreach(Choice questionChoice in currentChoices)
            {
                questionChoices[index].gameObject.SetActive(true);
                questionChoicesText[index].text = questionChoice.text;
                index++;
            }
            for (int i = index; i < questionChoices.Length; i++)
            {
                questionChoices[i].gameObject.SetActive(false);
            }
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }

    public void setStory(GameObject gameObject)
    {
        story = gameObject;
    }
}

