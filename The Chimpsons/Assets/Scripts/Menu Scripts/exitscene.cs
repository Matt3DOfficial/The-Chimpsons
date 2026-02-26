using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// only works when compiled as an .exe

public class SceneExit : MonoBehaviour {
    public Button playButton;
    
    void Start() {
        playButton.onClick.AddListener(exitScene);
    }

    void exitScene() {
        Debug.Log("exiting scene");
        Application.Quit();
    }

    public void TriggerClick() {
        playButton.onClick.Invoke();
    }
}