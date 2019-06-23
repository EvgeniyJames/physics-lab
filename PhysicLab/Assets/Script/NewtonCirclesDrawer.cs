using UnityEngine;

public class NewtonCirclesDrawer : MonoBehaviour
{
    public float lineWidth = 1;
    public int count;

    public GameObject prefab;

    public Color color = Color.black;
    public float lambda;
    public float radius;

    public void ReinitCircleCanvas()
    {
        ClearFromCirlces();
        Draw();
    }

    public void ReinitCircleCanvas(int lambda, int radius, Color color)
    {
        ClearFromCirlces();

        this.color = color;
        this.lambda = lambda;
        this.radius = radius;

        Draw();
    }

    public void Draw()
    {
        if (!IsDrawAllow())
            return;

        float mathPart = (radius / 100f) * (lambda / 1000000000f);
        for (int i = 0; i < count; i++)
        {
            float innerMathPart = Mathf.Sqrt(mathPart * (i + 1)) * 10000;

            AddCircle(innerMathPart);
        }
    }

    private bool IsDrawAllow()
    {
        return color != Color.black && lambda != 0 && radius != 0;
    }

    private void AddCircle(float radius)
    {
        var newCircle = Instantiate(prefab, transform);
        DrawCircle.AddToObject(newCircle, radius, lineWidth, color);
    }

    private void ClearFromCirlces()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject.GetComponent<LineRenderer>().material);

            Destroy(child.gameObject);
        }
    }
}
