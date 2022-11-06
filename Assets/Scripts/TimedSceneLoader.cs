using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedSceneLoader : MonoBehaviour
{
    public float delay = 32;
    public string NewLevel = "GameplayDemo";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}