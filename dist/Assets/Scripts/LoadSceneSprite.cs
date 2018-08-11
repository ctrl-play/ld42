using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneSprite : MonoBehaviour {



    // SceneManager.LoadScene(3);
    // Debug.Log("it worked");


    // Use this for initialization
    //void Start () {

    //}



    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            
        }

        

    }

    // Update is called once per frame

    void Update () {



        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left click, casting ray.");
            CastRay();
            Debug.Log("Hit object: " + collider.gameObject.name);
        }


    }
}
