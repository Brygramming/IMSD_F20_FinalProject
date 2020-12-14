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
	public Text InformationTitle;
    public Text Information;
    public GameObject[] Images = new GameObject[29]; //To make SetActive work
    public GameObject ButtonPrevious;
    public GameObject ButtonNext;

    //Link Button And Link Strings
    public GameObject ButtonLink;
    string HyperLinks;

    //LevelArray
    int[] Levels = {0, 1, 2, 3, 4, 5};
    public int LevelState;

    void Start()
    {
        HyperLinks = "";
        Images[28].SetActive(false);
    }

    void Update()
    {
        LevelControl();
        MapPullUp();
    }

    void StartMenu()
    {
    	Title.text = "Dirty Water";
        InformationTitle.text = "";
        Information.text = "";
        ButtonStart.SetActive(true);
        ButtonExit.SetActive(true);
        ButtonPrevious.SetActive(false);
        ButtonNext.SetActive(false);
        ButtonLink.SetActive(false);

        //Makes images false
        for(int i = 0; i < 28; i++)
    	{
    		Images[i].SetActive(false);
    	}
    }

    void LevelControl()
    {
        if(LevelState == Levels[5]) //Level 3
        {
            InformationTitle.text = "Test Three";
            Information.text = "Question Test 3";
            Images[1].SetActive(false);
            Images[2].SetActive(true);
        }
        else if(LevelState == Levels[4])
        {
        	InformationTitle.text = "Test Three";
            Information.text = "Question Test 3";
            Images[1].SetActive(false);
            Images[2].SetActive(true);
        }
        else if(LevelState == Levels[3])
        {
        	InformationTitle.text = "Test Three";
            Information.text = "Question Test 3";
            Images[11].SetActive(true);
            Images[12].SetActive(true);
            Images[13].SetActive(true);
            Images[14].SetActive(true);
            Images[15].SetActive(true);
            Images[16].SetActive(true);
        }
        else if(LevelState == Levels[2]) //Level 2
        {
            InformationTitle.text = "Gowanus canal";
            Information.text = "The Gowanus Canal is one of the most heavily contaminated water bodies in the nation. This 1.8 miles long, 100 foot wide, the canal was built in the 19th century and historically was home to many industries including manufactured gas plants, cement factories, oil refineries, tanneries, and chemical plants. After nearly 150 years of use, the canal has become heavily contaminated with PCBs, heavy metals, pesticides, volatile organic compounds, sewage solids from combined sewer overflows, and polycyclic aromatic hydrocarbons (PAHs). \nNo link is provided.";
            HyperLinks = "";
            Images[5].SetActive(true);
            Images[6].SetActive(true);
            Images[7].SetActive(true);
            Images[8].SetActive(true);
            Images[9].SetActive(true);
            Images[10].SetActive(true);
        }
        else if(LevelState == Levels[1]) //Level 1
        {
            InformationTitle.text = "Bronx River";
            Information.text = "Bronx River is still plagued by ongoing water pollution. Nearly every time it rains, raw sewage and polluted stormwater overflow from New York City's antiquated sewers. In a typical year, 455 million gallons of this 'combined sewer overflow' (CSO) are dumped into the Bronx River. \nClick link for more detailed information.";
            HyperLinks = "http://bronxriver.org/puma/images/usersubmitted/file/Eco/Bronx%20River%20LTCP%20factsheet.pdf";
            Images[0].SetActive(true);
            Images[1].SetActive(true);
            Images[2].SetActive(true);
            Images[3].SetActive(true);
            Images[4].SetActive(true);
            Title.text = "";
        }
        else if(LevelState == Levels[0]) //Start Menu
        {
            StartMenu();
        }
    }

    void MapPullUp()
    {
    	if(Input.GetKeyDown(KeyCode.M))
    	{
    		Images[28].SetActive(!Images[28].activeInHierarchy);
    	}
    }

    //All Button Interaction Below

    //Starting button
    public void StartingButton()
    {
        Debug.Log("Game Started");
        ButtonStart.SetActive(false);
        ButtonExit.SetActive(false);
        LevelState = 1;
        ButtonPrevious.SetActive(true);
        ButtonNext.SetActive(true);
        ButtonLink.SetActive(true);
    }

    //Quit Button
    public void Exiting()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    //Yes Button
    public void PrevButton()
    {
        if(LevelState == Levels[1] || LevelState == Levels[2] || LevelState == Levels[3] || LevelState == Levels[4] || LevelState == Levels[5])
        {
            LevelState -= 1;
        }

        for(int i = 0; i < 28; i++)
    	{
    		Images[i].SetActive(false);
    	}
    }

    //No Button
    public void NextButton()
    {
        if(LevelState == Levels[1] || LevelState == Levels[2] || LevelState == Levels[3] || LevelState == Levels[4] || LevelState == Levels[5])
        {
            LevelState += 1;
        }

        for(int i = 0; i < 28; i++)
    	{
    		Images[i].SetActive(false);
    	}
    }

    public void LinkButton()
    {
    	Application.OpenURL(HyperLinks);
    }
}
