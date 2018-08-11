using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneSprite : MonoBehaviour
{



    // SceneManager.LoadScene(3);
    // Debug.Log("it worked");


    // Use this for initialization
    //void Start () {

    //}






    // Update is called once per frame

    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Village")
                {
                    SceneManager.LoadScene("Explore");

                }

            }
        }
    }
}
               
            
        


    

