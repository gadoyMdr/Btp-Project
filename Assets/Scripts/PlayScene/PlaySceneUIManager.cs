using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneUIManager : MonoBehaviour
{
    [HideInInspector]
    public bool isPaused;

    [SerializeField]
    private Canvas pauseCanvas;

    private void Start()
    {
        TogglePause(false);
    }

    public void TogglePause(bool? value)
    {
        isPaused = value ?? !isPaused;
        pauseCanvas.gameObject.SetActive(isPaused);
    }

}
