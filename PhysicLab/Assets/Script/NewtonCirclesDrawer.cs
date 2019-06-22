using UnityEngine;

public class NewtonCirclesDrawer : MonoBehaviour
{
    public float lineWidth = 1;
    public int count;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < count; i++)
        {
            AddCircle(i);
        }
    }

    private void AddCircle(float radius)
    {
        var newCircle = Instantiate(prefab, transform);
        DrawCircle.AddToObject(newCircle, radius, lineWidth);
    }

    private void ClearFromCirlces()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void ReinitCircleCanvas(int lambda, int radius)
    {
        ClearFromCirlces();

        float mathPart = (radius / 100f) * (lambda / 1000000000f);
        Debug.Log("mathPart: " + mathPart);
        for (int i = 0; i < count; i++)
        {
            AddCircle(mathPart * (i + 1));
        }
    }
}
