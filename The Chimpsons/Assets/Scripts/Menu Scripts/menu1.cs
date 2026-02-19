using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quitManagement : MonoBehaviour {
    public Button quitButton;
    
    void Start() {
        quitButton.onClick.AddListener(changeScene);
        Debug.Log("changing scene");
    }

    void changeScene() {
        Debug.Log("changing scene");
        Application.Quit();
    }

    public void TriggerClick() {
        quitButton.onClick.Invoke();
    }
}