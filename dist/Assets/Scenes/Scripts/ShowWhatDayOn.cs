using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ShowWhatDayOn : MonoBehaviour {

    int Day = EndTurnButton.click;
    Text DayText;
    GameObject DayImage;
    GameObject Canvas;

    // Use this for initialization
    void Start () {
        

        DayText = GameObject.Find("DayText").GetComponent<Text>();  
            DayImage = GameObject.Find("DayImage");
            DayText.text = "Day " + Day;
            StartCoroutine(processTask());
        
    }

    IEnumerator processTask()
    {
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene(1);


    }


    // Update is called once per frame
    void Update () {
        
    }
}
