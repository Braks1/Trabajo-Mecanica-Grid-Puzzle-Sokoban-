using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objective1Code : MonoBehaviour
{
    public GameObject objective1;
    public winCondition winCondition;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            
            objective1.GetComponent<SpriteRenderer>().color = Color.green;
            winCondition.checkValue++;
            
        }
    }
}
