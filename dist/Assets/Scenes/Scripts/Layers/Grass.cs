using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {




    SpriteRenderer Alpha;

    void CheckDay()
    {
        int Day = EndTurnButton.click;

        if (Day >= 6)
        {
            Alpha = GameObject.Find("Grass").GetComponent<SpriteRenderer>();

            Color tmp = Alpha.color;
            tmp.a = 0.3f;
            GetComponent<SpriteRenderer>().color = tmp;
        }
        if (Day >= 7)
        {
            Object.Destroy(GameObject.Find("Grass"));
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
