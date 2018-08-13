using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour {

    public GameObject info;
    public GameObject main;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            if (main.activeSelf)
            {
                info.SetActive(true);
                main.SetActive(false);
            }
        }
    }
}
