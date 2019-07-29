using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class OnSceneObjectPressEnablerDisabler : MonoBehaviour
{
    public GameObject toEnable;
    public GameObject toDisable;

    private void OnMouseDown()
    {
        OnPressed();
    }

    public void OnPressed()
    {
        toEnable.SetActive(true);

        if (toDisable)
            toDisable.SetActive(false);
        else
            gameObject.SetActive(false);
    }
}
