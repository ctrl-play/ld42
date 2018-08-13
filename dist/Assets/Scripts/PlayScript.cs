using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour {

    public GameObject info;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            if (!GameManager.Instance.haveChosenChar)
            {
                info.SetActive(true);
            }
        }
    }
}
