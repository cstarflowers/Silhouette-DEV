using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedSceneLoader : MonoBehaviour
{
    public float delay;
    public string newLevel;
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Initiate.Fade(newLevel,Color.black,1);
    }
}