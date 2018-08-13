using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ActionScript : MonoBehaviour {

    int Energy2 = PlaceScript.number5;
    Text Energy;
    int StartingEnergy = 5;


    public void ActionNumber() {

        Energy = GameObject.Find("Action Number").GetComponent<Text>();
        Energy.text = --Energy2 + " / 5";


        Debug.Log(Energy);


    }

    


	// Use this for initialization
	void Start () {
        ActionNumber();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
