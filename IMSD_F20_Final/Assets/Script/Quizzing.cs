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
    public GameObject[] Images = new GameObject[29]; //To make SetActive work for images
    public GameObject ButtonPrevious;
    public GameObject ButtonNext;

    //Link Button And Link Strings
    public GameObject ButtonLink;
    string HyperLinks;

    //LevelArray
    int[] Levels = {0, 1, 2, 3, 4, 5, 6};
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

        //Makes Images False
        for(int i = 0; i < 28; i++)
    	{
    		Images[i].SetActive(false);
    	}
    }

    void LevelControl()
    {
        if(LevelState == Levels[6]) //Mini Game!!
        {
            //Turning off the texts and buttons
            Debug.Log("Mini Game");
            InformationTitle.text = "";
            Information.text = "";
            ButtonPrevious.SetActive(false);
            ButtonNext.SetActive(false);
            ButtonLink.SetActive(false);

            //Mini Game

        }
        else if(LevelState == Levels[5]) //Level 5
        {
            InformationTitle.text = "Hudson river";
            Information.text = "Between 1947 and 1977, General Electric dumped an estimated 1.3 million pounds of polychlorinated biphenyls (PCBs) into the Hudson River. The source of the PCB discharges was two GE capacitor manufacturing plants located in Fort Edward and Hudson Falls, New York, about 50 miles north of Albany. GE’s PCBs are now found in sediment, water and wildlife throughout the Hudson River ecosystem as far south as the New York Harbor. They are also found in people. \nClick link for more detailed information.";
            HyperLinks = "https://www.riverkeeper.org/water-quality/testing/what/other-pollutants/";
            ButtonLink.SetActive(true);
            Images[20].SetActive(true);
            Images[21].SetActive(true);
            Images[22].SetActive(true);
            Images[23].SetActive(true);
            Images[24].SetActive(true);
            Images[25].SetActive(true);
            Images[26].SetActive(true);
            Images[27].SetActive(true);
        }
        else if(LevelState == Levels[4]) //Level 4
        {
        	InformationTitle.text = "Harlem river";
            Information.text = "The Harlem River in New York City has provided the city’s communities with recreational opportunities like boating and fishing since the 1700s. Over time, human activities along the Harlem River, such as shipping, industry, and waste disposal, have severely affected the overall water quality of the river. \nNo link is provided.";
            HyperLinks = "";
            ButtonLink.SetActive(false);
            Images[17].SetActive(true);
            Images[18].SetActive(true);
            Images[19].SetActive(true);
        }
        else if(LevelState == Levels[3]) //Level 3
        {
        	InformationTitle.text = "Gowanus canal";
            Information.text = "The Gowanus Canal is one of the most heavily contaminated water bodies in the nation. This 1.8 miles long, 100 foot wide, the canal was built in the 19th century and historically was home to many industries including manufactured gas plants, cement factories, oil refineries, tanneries, and chemical plants. After nearly 150 years of use, the canal has become heavily contaminated with PCBs, heavy metals, pesticides, volatile organic compounds, sewage solids from combined sewer overflows, and polycyclic aromatic hydrocarbons (PAHs). \nNo link is provided.";
            HyperLinks = "";
            ButtonLink.SetActive(false);
            Images[11].SetActive(true);
            Images[12].SetActive(true);
            Images[13].SetActive(true);
            Images[14].SetActive(true);
            Images[15].SetActive(true);
            Images[16].SetActive(true);
        }
        else if(LevelState == Levels[2]) //Level 2
        {
            InformationTitle.text = "Flushing bay";
            Information.text = "Flushing Bay has one of the largest CSO outfalls, which alone dumps a billion gallons of sewage and stormwater into Flushing Bay every year. \nClick link for more detailed information.";
            HyperLinks = "https://www.guardiansofflushingbay.org/about-flushing-bay";
            ButtonLink.SetActive(true);
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
            ButtonLink.SetActive(true);
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
