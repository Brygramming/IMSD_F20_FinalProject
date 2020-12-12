using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizing : MonoBehaviour
{
	public Text QuestionTitle;
    public Text Question;
    public Button Button1;
    public Button Button2;
    public Image Imagining;

    //Starting Menu
    public Text Title;

    public Button StartButton;
    public Button ExitButton;

    //LevelArray
    int[] LevelState = {0, 1, 2, 3};

    void Start()
    {

    }

    void Update()
    {
        if(LevelState[3] == 3)
        {
        	QuestionTitle.text = "Test Three";
        	Question.text = "Question Test 3";
        	Imagining.name = "Test Image";
        }
        else if(LevelState[2] == 2)
        {
        	QuestionTitle.text = "Test Two";
        	Question.text = "Question Test 2";
        	Imagining.name = "Test Image";
        }
        else if(LevelState[1] == 1)
        {
        	QuestionTitle.text = "Test One";
        	Question.text = "Question Test 1";
        	Imagining.name = "Test Image";
        }
        else if(LevelState[0] == 0) //Start Menu
        {
        	StartMenu();
        }
    }

    void StartMenu()
    {
    	Title.text = "Dirty Water";
    }
}
