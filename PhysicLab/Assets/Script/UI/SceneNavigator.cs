using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour {

    public string sceneName;

    public void OnNewScenePressed()
    {
        SceneManager.LoadScene(sceneName);
    }
}
