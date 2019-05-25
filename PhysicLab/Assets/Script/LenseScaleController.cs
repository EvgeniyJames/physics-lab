using UnityEngine;
using UnityEngine.UI;

public class LenseScaleController : MonoBehaviour {

    private int step;

    public int stepLimit;

    public float interpolationStep;

    public GameObject arrowsContainer;

    private StepIncreaseCoordinator StepIncreaseCoordinator;
    private StepDecreaseCoordinator StepDecreaseCoordinator;


    public Text textWidget;
    private int curveRadius = 75;

    // Use this for initialization
    void Start () {

        Debug.Assert(arrowsContainer, "LenseScaleController of " + name + " has no arrowsContainer");
        if (arrowsContainer)
        {
            StepIncreaseCoordinator = arrowsContainer.GetComponent<StepIncreaseCoordinator>();
            StepDecreaseCoordinator = arrowsContainer.GetComponent<StepDecreaseCoordinator>();
        }
        UpdateTextWidget();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Increase()
    {
        if (step >= stepLimit)
            return;

        step++;
        transform.localScale -= new Vector3(0, interpolationStep, 0);

        StepDecreaseCoordinator.MakeStep();

        curveRadius += 5;
        UpdateTextWidget();
    }

    public void Decrease()
    {
        if (step <= -stepLimit)
            return;

        step--;
        transform.localScale += new Vector3(0, interpolationStep, 0);

        StepIncreaseCoordinator.MakeStep();

        curveRadius -= 5;
        UpdateTextWidget();
    }

    private void UpdateTextWidget()
    {
        if (textWidget)
            textWidget.text = "" + curveRadius;
    }
}
