using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{

    SpriteRenderer Alpha;

    void CheckDay()
    {
        int Day = EndTurnButton.click;

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
    }
        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {
         CheckDay();
        }
    }

