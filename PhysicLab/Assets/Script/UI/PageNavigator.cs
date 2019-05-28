using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageNavigator : MonoBehaviour {

    public RectTransform nextPanel; 
    
    public void OnNextPanelPressed()
    {
        RectTransform rectTransform = transform.parent.transform as RectTransform;
        rectTransform.Translate(new Vector2(-Screen.width, 0));

        nextPanel.Translate(new Vector2(-Screen.width, 0));
    }
}
