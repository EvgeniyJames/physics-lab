using UnityEngine;

public class DrawCircle : MonoBehaviour
{
    public float radius;
    public float lineWidth;

    public Color color;

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
        gameObject.DrawCircle(radius, lineWidth, color);
    }

    public static void AddToObject(GameObject where, float radius, float lineWidth, Color color)
    {
        DrawCircle drawCircle = where.AddComponent<DrawCircle>();
        drawCircle.radius = radius;
        drawCircle.lineWidth = lineWidth;
        drawCircle.color = color;
        drawCircle.Init();
    }
}
