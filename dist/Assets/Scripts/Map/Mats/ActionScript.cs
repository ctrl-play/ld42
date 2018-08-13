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

    public void ActionNumber(string type) {
        if (Energy2 > 0)
        {
            switch (type)
            {
                case "forest":
                    wood += Random.Range(0, 5);
                    woodText.text = wood.ToString();
                    energy = GameObject.Find("Action Number").GetComponent<Text>();
                    energy.text = --Energy2 + " / 5";
                    break;
                case "mine":
                    stone += Random.Range(0, 5);
                    stoneText.text = stone.ToString();
                    energy = GameObject.Find("Action Number").GetComponent<Text>();
                    energy.text = --Energy2 + " / 5";
                    break;
                case "village":
                    cloth += Random.Range(0, 5);
                    clothText.text = cloth.ToString();
                    rope += Random.Range(0, 2);
                    ropeText.text = rope.ToString();
                    energy = GameObject.Find("Action Number").GetComponent<Text>();
                    energy.text = --Energy2 + " / 5";
                    break;
                case "null":
                    break;
            }
        }
    }

    private void Awake()
    {
        Energy2 = 6;
        energy = GameObject.Find("Action Number").GetComponent<Text>();
        energy.text = --Energy2 + " /5";
    }
}
