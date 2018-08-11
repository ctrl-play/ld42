using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadForestScene : MonoBehaviour {






    public int num;

// Use this for initialization
void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(num);
            Debug.Log("Scene changed to " + num);
        }
    }
}
