using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManagement : MonoBehaviour {
    public Button playButton;
    
    void Start() {
        playButton.onClick.AddListener(changeScene);
        Debug.Log("changing scene");
    }

    void changeScene() {
        Debug.Log("changing scene");
        Scene currentScene = SceneManager.GetActiveScene();
        var newScene = "SampleScene";
        SceneManager.LoadSceneAsync(newScene);
        SceneManager.UnloadSceneAsync(currentScene);
    }

    public void TriggerClick() {
        playButton.onClick.Invoke();
    }
}