using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MakeGroudTrans : MonoBehaviour {


    SpriteRenderer Alpha;


    //int Day = EndTurnButton.click;

    //void MakeLayerTransparent()
    //{
    //    Alpha = GameObject.Find("Sand").GetComponent<SpriteRenderer>();

    //    Color tmp = Alpha.color;
    //    tmp.a = 0.3f;
    //    GetComponent<SpriteRenderer>().color = tmp;

    //}

    

    void CheckDay()
    {
        SpriteRenderer Alpha;
        int Day = EndTurnButton.click;

        if (Day >= 2 )
        {
            Alpha = GameObject.Find("Sand").GetComponent<SpriteRenderer>();

            Color tmp = Alpha.color;
            tmp.a = 0.3f;
            GetComponent<SpriteRenderer>().color = tmp;
        }
        if (Day >= 3)
        {
            Object.Destroy(GameObject.Find("Sand"));
        }
        if (Day >= 4)
        {

            Alpha = GameObject.Find("Dirt").GetComponent<SpriteRenderer>();

            Color tmp = Alpha.color;
            tmp.a = 0.3f;
            GetComponent<SpriteRenderer>().color = tmp;
        }
        if (Day >= 5)
        {
            Object.Destroy(GameObject.Find("Dirt"));
        }
        //if (Day >= 6)
        //{
        //    Alpha = GameObject.Find("Grass").GetComponent<SpriteRenderer>();

        //    Color tmp = Alpha.color;
        //    tmp.a = 0.3f;
        //    GetComponent<SpriteRenderer>().color = tmp;
        //}
        //if (Day >= 7)
        //{
        //    Object.Destroy(GameObject.Find("Grass"));
        //}
        //if (Day >= 8)
        //{
        //    Alpha = GameObject.Find("Grass2").GetComponent<SpriteRenderer>();

        //    Color tmp = Alpha.color;
        //    tmp.a = 0.3f;
        //    GetComponent<SpriteRenderer>().color = tmp;
        //}
        //if (Day > 9)
        //{
        //    Object.Destroy(GameObject.Find("Grass2"));
        //}
    }

    


	// Use this for initialization
	void Start () {
       
        
    }
	
	// Update is called once per frame
	void Update () {
        CheckDay();
    }
}
