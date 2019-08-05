using UnityEngine;

public class DrawRuler : MonoBehaviour
{
    public int counter;
    public Color color;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void Draw()
    {
        Clear();

        for (int i = 0; i < 10; i++)
        {
            var newLine = Instantiate(prefab, transform);
            AddToObject(newLine, i, color);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Init()
    {
        gameObject.DrawRuler(counter, color);
    }

    public static void AddToObject(GameObject where, int counter, Color color)
    {
        DrawRuler drawCircle = where.GetComponent<DrawRuler>();

        if (!drawCircle)
            drawCircle = where.AddComponent<DrawRuler>();

        drawCircle.counter = counter;
        drawCircle.color = color;
        drawCircle.Init();
    }

    private void Clear()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject.GetComponent<LineRenderer>().material);

            Destroy(child.gameObject);
        }
    }
}
