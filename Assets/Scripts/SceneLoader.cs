using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string newLevel;
    // public float delay;
    public float fadeSpeed;
    public AudioSource interactSound;

    void Start()
    {
        Application.targetFrameRate = 60;
        // StartCoroutine(LoadLevelAfterDelay(delay));
    }

    //IEnumerator LoadLevelAfterDelay(float delay)
    //{
        // yield return new WaitForSeconds(delay);
    //}

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return))
        {
            // SceneManager.LoadScene(NewLevel);
            Initiate.Fade(newLevel,Color.black,fadeSpeed);
            interactSound.Play();
        }
    }
}