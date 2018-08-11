using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour {

    public int increase;

    public void Up()
    {
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + increase);
    }

    public void Down()
    {
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - increase);
    }
}
