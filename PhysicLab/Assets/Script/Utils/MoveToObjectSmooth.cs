using UnityEngine;

public class MoveToObjectSmooth : MonoBehaviour
{
    public Vector3 destinationPostition;
    public Quaternion destinationRotation;
    public float speed = 1f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, destinationPostition, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, destinationRotation, speed * Time.deltaTime);
    }

    public static void AddToObject(GameObject where, Vector3 destination, Quaternion rotation)
    {
        Destroy(where.GetComponent<MoveToObjectSmooth>());

        MoveToObjectSmooth smooth = where.AddComponent<MoveToObjectSmooth>();
        smooth.destinationPostition = destination;
        smooth.destinationRotation = rotation;
    }
}
