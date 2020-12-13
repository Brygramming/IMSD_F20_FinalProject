using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizzing : MonoBehaviour
{
    //Starting Menu
    public Text Title;
    public GameObject ButtonStart;
    public GameObject ButtonExit;

	public Text QuestionTitle;
    public Text Question;
    public GameObject[] Images = new GameObject[3];
    public GameObject ButtonTrue;
    public GameObject ButtonFalse;

    //LevelArray
    int[] Levels = {0, 1, 2, 3};
    public int LevelState;

    void Start()
    {
        
    }

    void Update()
    {
        LevelControl();
    }

    void StartMenu()
    {
    	Title.text = "Dirty Water";
        QuestionTitle.text = "";
        Question.text = "";
        ButtonTrue.SetActive(false);
        ButtonFalse.SetActive(false);
    }

    void LevelControl()
    {
        if(LevelState == Levels[3]) //Level 3
        {
            QuestionTitle.text = "Test Three";
            Question.text = "Question Test 3";
            Images[1].SetActive(false);
            Images[2].SetActive(true);
        }
        else if(LevelState == Levels[2]) //Level 2
        {
            QuestionTitle.text = "Test Two";
            Question.text = "Question Test 2";
            Images[0].SetActive(false);
            Images[1].SetActive(true);
        }
        else if(LevelState == Levels[1]) //Level 1
        {
            QuestionTitle.text = "Test One";
            Question.text = "Question Test 1";
            Images[0].SetActive(true);
            Images[1].SetActive(false);
            Images[2].SetActive(false);
            Title.text = "";
        }
        else if(LevelState == Levels[0]) //Start Menu
        {
            StartMenu();
            Images[0].SetActive(false);
            Images[1].SetActive(false);
            Images[2].SetActive(false);
        }
    }

    //Starting button
    public void StartingButton()
    {
        Debug.Log("Game Started");
        ButtonStart.SetActive(false);
        ButtonExit.SetActive(false);
        LevelState = 1;
        ButtonTrue.SetActive(true);
        ButtonFalse.SetActive(true);
    }

    //Quit Button
    public void Exiting()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    //Yes Button
    public void TrueAnswer()
    {
        if(LevelState == Levels[1] || LevelState == Levels[2] || LevelState == Levels[3])
        {
            LevelState += 1;
        }
    }

    //No Button
    public void FalseAnswer()
    {
        if(LevelState == Levels[1] || LevelState == Levels[2] || LevelState == Levels[3])
        {
            LevelState += 1;
        }
    }
}
