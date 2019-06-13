using UnityEngine;

public class DrawCircle : MonoBehaviour
{
    public float radius;
    public float lineWidth;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.DrawCircle(radius, lineWidth);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
