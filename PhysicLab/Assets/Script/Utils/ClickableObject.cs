using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<SceneNavigator>().OnNewScenePressed();
}
}
