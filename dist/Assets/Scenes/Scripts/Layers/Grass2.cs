using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass2 : MonoBehaviour {


    SpriteRenderer Alpha;

    void CheckDay()
    {
        int Day = EndTurnButton.click;
        if (Day >= 8)
        {
            Alpha = GameObject.Find("Grass2").GetComponent<SpriteRenderer>();

            Color tmp = Alpha.color;
            tmp.a = 0.3f;
            GetComponent<SpriteRenderer>().color = tmp;
        }
        if (Day > 9)
        {
            Object.Destroy(GameObject.Find("Grass2"));
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckDay();

    }
}
