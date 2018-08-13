using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grass2 : MonoBehaviour {


    SpriteRenderer Alpha;
    int Day = EndTurnButton.click;

    void CheckDay()
    {
        if (Day >= 8)
        {
            Alpha = GameObject.Find("Grass2").GetComponent<SpriteRenderer>();

            Color tmp = Alpha.color;
            tmp.a = 0.3f;
            GetComponent<SpriteRenderer>().color = tmp;
        }
        if (Day == 9)
        {
            SceneManager.LoadScene(3);
        }
    }
	// Update is called once per frame
	void Update () {
        CheckDay();
    }
}
