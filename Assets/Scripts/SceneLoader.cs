using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string newLevel;
    // public float delay;
    public float fadeSpeed;

    void Start()
    {
        // StartCoroutine(LoadLevelAfterDelay(delay));
    }

    //IEnumerator LoadLevelAfterDelay(float delay)
    //{
        // yield return new WaitForSeconds(delay);
    //}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // SceneManager.LoadScene(NewLevel);
            Initiate.Fade(newLevel,Color.black,fadeSpeed);
        }
    }
}