using UnityEngine;

public class DrawCircle : MonoBehaviour
{
    public float radius;
    public float lineWidth;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Init()
    {
        gameObject.DrawCircle(radius, lineWidth);
    }

    public static void AddToObject(GameObject where, float radius, float lineWidth)
    {
        DrawCircle drawCircle = where.AddComponent<DrawCircle>();
        drawCircle.radius = radius;
        drawCircle.lineWidth = lineWidth;
        drawCircle.Init();
    }
}
