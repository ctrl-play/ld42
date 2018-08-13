using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ActionScript : MonoBehaviour {

    public static int Energy2 = PlaceScript.number5;
    Text energy;
    int startingEnergy = 5;
    int wood = 0;
    int stone = 0;
    int cloth = 0;
    int rope = 0;
    public Text woodText;
    public Text stoneText;
    public Text clothText;
    public Text ropeText;
    public float percentWood = 0f;
    public float percentStone = 0f;
    public float percentCloth = 0f;
    public float percentRope = 0f;
    public float percent = 0f;
    public Text percentText;
    public GameObject endTurnButton;
    public Text chanceOfSurvival;
    public float finishNumber;
    public Text missionStatus;

    public void ActionNumber(string type) {
        if (Energy2 > 0)
        {
            switch (type)
            {
                case "forest":
                    wood += Random.Range(1, 6);
                    woodText.text = wood.ToString();
                    energy = GameObject.Find("Action Number").GetComponent<Text>();
                    energy.text = --Energy2 + " / 5";
                    break;
                case "mine":
                    stone += Random.Range(1, 6);
                    stoneText.text = stone.ToString();
                    energy = GameObject.Find("Action Number").GetComponent<Text>();
                    energy.text = --Energy2 + " / 5";
                    break;
                case "village":
                    cloth += Random.Range(1, 6);
                    clothText.text = cloth.ToString();
                    rope += Random.Range(1, 3);
                    ropeText.text = rope.ToString();
                    energy = GameObject.Find("Action Number").GetComponent<Text>();
                    energy.text = --Energy2 + " / 5";
                    break;
                case "null":
                    break;

            }
            if (wood <= 45)
            {
                percentWood = wood * 0.6f;
            }
            else if (wood > 45)
            {
                percentWood = 45 * 0.6f;
            }

            if (stone <= 45)
            {
                percentStone = stone * 0.6f;
            }
            else if (stone > 45)
            {
                percentStone = 45 * 0.6f;
            }

            if (cloth <= 45)
            {
                percentCloth = cloth * 0.6f;
            }
            else if (cloth > 45)
            {
                percentCloth = 45 * 0.6f;
            }

            if (rope <= 15)
            {
                percentRope = rope * 0.6f;
            }
            else if (rope > 15)
            {
                percentRope = 15 * 0.6f;
            }
        }
    }

    private void Awake()
    {
        Energy2 = 6;
        energy = GameObject.Find("Action Number").GetComponent<Text>();
        energy.text = --Energy2 + " /5";
    }

    private void Update()
    {
        percent = percentWood + percentStone + percentCloth + percentRope;
        System.Math.Round(percent, 2);
        if(percent > 100)
        {
            percent = 100;
        }
        percentText.text = "Set Sail " + percent + "% Success";

        chanceOfSurvival.text = "Chance of survival: " + percent.ToString() + "%";
    }

    public void Finish()
    {
        finishNumber = Random.Range(0f, 100f);
        if (finishNumber < percent)
        {
            missionStatus.text = "Success!!";
            missionStatus.color = Color.green;
        }else if(finishNumber > percent)
        {
            missionStatus.text = "You Failed!\nYour boat sank! :(";
            missionStatus.color = Color.red;
        }
    }
}
