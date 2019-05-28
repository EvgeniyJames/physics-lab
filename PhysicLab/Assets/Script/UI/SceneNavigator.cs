using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneNavigator : MonoBehaviour {

    public string sceneName;

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(OnNewScenePressed);
	}

    void OnNewScenePressed()
    {
        SceneManager.LoadScene(sceneName);
    }
}
