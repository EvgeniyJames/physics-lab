using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneNavigator : MonoBehaviour {

    public string sceneName;

    public void OnNewScenePressed()
    {
        SceneManager.LoadScene(sceneName);
    }
}
