using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class ClickableObject : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<SceneNavigator>().OnNewScenePressed();
}
}
