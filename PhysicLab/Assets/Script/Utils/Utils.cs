using UnityEngine;

public static class GameObjectEx
{
    public static void DrawCircle(this GameObject container, float radius, float lineWidth, Color color)
    {
        var segments = 60;
        var line = container.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.startWidth = lineWidth;
        line.endWidth = lineWidth;
        line.positionCount = segments + 1;

        line.material = new Material(Shader.Find("Mobile/Particles/Additive"));
        line.startColor = color;
        line.endColor = color;

        var pointCount = segments + 1; // add extra point to make startpoint and endpoint the same to close the circle
        var points = new Vector3[pointCount];

        for (int i = 0; i < pointCount; i++)
        {
            var rad = Mathf.Deg2Rad * (i * 360f / segments);
            points[i] = new Vector3(Mathf.Sin(rad) * radius, 0, Mathf.Cos(rad) * radius);
        }

        line.SetPositions(points);
    }

    public static void DrawRuler(this GameObject container, int counter, Color color)
    {
        //container.AddComponent<LineRenderer>();
        LineRenderer lr = container.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Legacy Shaders/Particles/Alpha Blended Premultiply"));
        lr.startColor = color;
        lr.endColor = color;
        lr.startWidth = 0.1f;
        lr.endWidth = 0.1f;

        Vector3 newPos = new Vector3(10 * counter, 200f, 0);

        lr.SetPosition(0, newPos);
        lr.SetPosition(1, newPos);
    }
}
