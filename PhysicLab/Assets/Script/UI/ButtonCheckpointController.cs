using UnityEngine;
using UnityEngine.UI;

public class ButtonCheckpointController : MonoBehaviour
{
    public GameObject movingObject;
    public GameObject cameraPoint;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed()
    {
        MoveToObjectSmooth.AddToObject(movingObject, cameraPoint.transform.position, cameraPoint.transform.rotation);
    }
}
