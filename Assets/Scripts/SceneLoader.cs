using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string newLevel;
    public float fadeSpeed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // SceneManager.LoadScene(NewLevel);
            Initiate.Fade(newLevel,Color.black,fadeSpeed);
        }
    }
}

