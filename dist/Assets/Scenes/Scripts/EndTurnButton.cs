using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class EndTurnButton : MonoBehaviour
{

    public static int click = 1;

    public static EndTurnButton Instance;
    
    public void SaveNumberData()
    {

       click++;
        Debug.Log(click);
        SceneManager.LoadScene(3);
    }


}


















