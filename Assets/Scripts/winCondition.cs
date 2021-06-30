using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winCondition : MonoBehaviour
{
    public static int checkValue = 0;
    bool winUnlocked = false;
    public GameObject Player;

    void Start()
    {
        checkValue = 0;
        winUnlocked = false;

    }

    void Update()
    {
        if (checkValue == 2)
        {
            winUnlocked = true;
        }

        if (winUnlocked == true)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
