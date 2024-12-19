using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;        // 音效來源
    public bool playOnAwake = false;       // 是否在啟動時就播放
    void Start()
    {
        audioSource.playOnAwake = playOnAwake;
        if (playOnAwake) audioSource.Play();
    }

    // Update is called once per frame
    void Update() {
       if (Input.GetKeyDown(KeyCode.Space)) {
            if (audioSource.isPlaying) {
                PauseAudio();
            }
            else {
                PlayAudio();
            }
       }
    }

    public void PlayAudio() {
        audioSource.Play();
    }

    public void PauseAudio() {
        if (audioSource.isPlaying) {
            audioSource.Pause();
        }
    }
}
