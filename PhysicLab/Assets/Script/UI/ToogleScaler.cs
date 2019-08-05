using UnityEngine;
using UnityEngine.UI;

public class ToogleScaler : MonoBehaviour
{
    public GameObject scaleObject;
    public float scaleTo;

    private bool isScaled;

    private Vector3 startScale;
    private Vector3 newScale;

    // Start is called before the first frame update
    void Start()
    {
        startScale = (scaleObject.transform.localScale);
        newScale = new Vector3(scaleTo, scaleTo, scaleTo);

        GetComponent<Button>().onClick.AddListener(OnScaleToogle);
    }

    public void OnScaleToogle()
    {
        if (isScaled)
            scaleObject.GetComponent<RectTransform>().localScale = startScale;
        else
            scaleObject.GetComponent<RectTransform>().localScale = newScale;

        Canvas.ForceUpdateCanvases();

        isScaled = !isScaled;
    }
}
