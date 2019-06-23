using UnityEngine;

public class LightBlinker : MonoBehaviour
{
    public float lowBound;
    public float highBound;

    public float speed;

    private float delta;

    private Light thisLight;

    void Start()
    {
        thisLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime * speed;
        thisLight.intensity = Mathf.Lerp(lowBound, highBound, Mathf.Abs(Mathf.Sin(delta)));
    }
}
