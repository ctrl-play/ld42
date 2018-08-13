using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoesNotDelet : MonoBehaviour {


    public static DoesNotDelet Instance;

    void Awake()
    {

        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

        // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
