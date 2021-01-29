using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    void Quit()
    {
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("main");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("hard");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Quit();
        }
    }
}