using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objective2Code : MonoBehaviour
{
    public GameObject objective2;
    public winCondition winCondition;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {

            objective2.GetComponent<SpriteRenderer>().color = Color.green;
            winCondition.checkValue++;

        }
    }
}