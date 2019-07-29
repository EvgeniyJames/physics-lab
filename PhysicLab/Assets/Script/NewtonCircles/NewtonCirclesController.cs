using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewtonCirclesController : MonoBehaviour
{
    public GameObject canvas;
    public GameObject world;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        world.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
