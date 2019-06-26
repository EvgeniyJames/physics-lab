using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{
    public Text textField;

    // Update is called once per frame
    void Update()
    {
        if (textField)
        {
            textField.text = "FPS " + (int)(1f / Time.unscaledDeltaTime);
        }
    }
}
