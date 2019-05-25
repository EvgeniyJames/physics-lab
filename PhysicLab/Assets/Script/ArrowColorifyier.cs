using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowColorifyier : MonoBehaviour {

    public GameObject arrowContainer;

	// Use this for initialization
	void Start () {
        for(int i = 0; i < transform.childCount; i++)
        {
            Button button = transform.GetChild(i).GetComponent<Button>();
            button.onClick.AddListener(() => ColorArrows(button.GetComponent<Image>().color));
        }
        Debug.Log(transform.childCount);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ColorArrows(Color color)
    {
        for(int i = 0; i < arrowContainer.transform.childCount; i++)
        {
            SpriteRenderer spriteRenderer = arrowContainer.transform.GetChild(i).GetComponent<SpriteRenderer>();
            if(spriteRenderer)
            {
                spriteRenderer.color = color;
            }
            else
            {
                arrowContainer.transform.GetChild(i).GetChild(0).GetComponent<SpriteRenderer>().color = color;
            }
        }
    }
}
