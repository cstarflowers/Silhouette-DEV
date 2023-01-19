using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    double timeInstantiated;
    public float assignedTime;
    public string direction;

    void Start()
    {
        timeInstantiated = SongManager.GetAudioSourceTime();
        if (this.gameObject.name.Contains("Up")) {
            direction = "up";
        }
        else if (this.gameObject.name.Contains("Down")) {
            direction = "down";
        }
        else if (this.gameObject.name.Contains("Left")) {
            direction = "left";
        }
        else if (this.gameObject.name.Contains("Right")) {
            direction = "right";
        }
    }

    // Update is called once per frame
    void Update()
    {
        double timeSinceInstantiated = SongManager.GetAudioSourceTime() - timeInstantiated;
        float t = (float)(timeSinceInstantiated / (SongManager.Instance.noteTime * 2));

        if (t > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            switch(direction) {
                case "up":
                    transform.localPosition = Vector3.Lerp(Vector3.down * SongManager.Instance.noteSpawnY, Vector3.down * SongManager.Instance.noteDespawnY, t); 
                    break;
                case "down":
                    transform.localPosition = Vector3.Lerp(Vector3.up * SongManager.Instance.noteSpawnY, Vector3.up * SongManager.Instance.noteDespawnY, t); 
                    break;
                case "right":
                    transform.localPosition = Vector3.Lerp(Vector3.left * SongManager.Instance.noteSpawnX, Vector3.left * SongManager.Instance.noteDespawnX, t); 
                    break;
                case "left":
                    transform.localPosition = Vector3.Lerp(Vector3.right * SongManager.Instance.noteSpawnX, Vector3.right * SongManager.Instance.noteDespawnX, t); 
                    break;
            }
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}