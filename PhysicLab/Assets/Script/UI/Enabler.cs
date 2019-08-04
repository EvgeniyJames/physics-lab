using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Enabler : MonoBehaviour
{
    public GameObject toEnable;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnEnableItem);
    }

    public void OnEnableItem()
    {
        if (toEnable)
            toEnable.SetActive(!toEnable.active);
    }
}
