using UnityEngine;

public class StepIncreaseCoordinator : MonoBehaviour {

    public enum SIDE { UP, LEFT, DEPTH};
    public SIDE side;

    public float step;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeStep()
    {
        if(side == SIDE.UP)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + step, transform.localPosition.z);
        }
    }
}
