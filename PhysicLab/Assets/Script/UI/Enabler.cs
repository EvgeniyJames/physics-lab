using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Enabler : MonoBehaviour
{
    public GameObject toEnable;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnEnable);
    }

    public void OnEnable()
    {
        if (toEnable)
            toEnable.SetActive(!toEnable.activeSelf);
    }
}
