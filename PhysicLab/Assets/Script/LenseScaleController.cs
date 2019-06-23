using UnityEngine;
using UnityEngine.UI;

public class LenseScaleController : MonoBehaviour {

    private int step;

    public int stepLimit;

    public float interpolationStep;

    public GameObject arrowsContainer;

    private StepIncreaseCoordinator StepIncreaseCoordinator;
    private StepDecreaseCoordinator StepDecreaseCoordinator;

    public NewtonCirclesDrawer NewtonCirclesDrawer;

    public Text textWidget;
    private int curveRadius = 75;

    // Use this for initialization
    void Start () {

        Debug.Assert(NewtonCirclesDrawer, "NewtonCirclesDrawer of " + name + " is lost");

        Debug.Assert(arrowsContainer, "LenseScaleController of " + name + " is lost");
        if (arrowsContainer)
        {
            StepIncreaseCoordinator = arrowsContainer.GetComponent<StepIncreaseCoordinator>();
            StepDecreaseCoordinator = arrowsContainer.GetComponent<StepDecreaseCoordinator>();
        }
        Notify();
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
        Notify();
    }

    public void Decrease()
    {
        if (step <= -stepLimit)
            return;

        step--;
        transform.localScale += new Vector3(0, interpolationStep, 0);

        StepIncreaseCoordinator.MakeStep();

        curveRadius -= 5;
        Notify();
    }

    private void Notify()
    {
        UpdateTextWidget();
        NotifyNewtonController();
    }

    private void UpdateTextWidget()
    {
        if (textWidget)
            textWidget.text = "" + curveRadius;
    }

    private void NotifyNewtonController()
    {
        if (NewtonCirclesDrawer)
        {
            NewtonCirclesDrawer.radius = curveRadius;
            NewtonCirclesDrawer.ReinitCircleCanvas();
        }
    }
}
