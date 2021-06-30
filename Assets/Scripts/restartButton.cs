using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class restartButton : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}