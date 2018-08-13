using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ShowWhatDayOn : MonoBehaviour {

    int Day = EndTurnButton.click;
    Text DayText;
    GameObject Canvas;

    // Use this for initialization
    void Start () {
        if (Day <= 8)
        {
            DayText = GameObject.Find("DayText").GetComponent<Text>();
            DayText.text = "Day " + Day;
            StartCoroutine(processTask());
        }
    }

    IEnumerator processTask()
    {
        if(Day<=8)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(1);

        }
    }
}
