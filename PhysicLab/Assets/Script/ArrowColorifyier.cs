using UnityEngine;
using UnityEngine.UI;

public class ArrowColorifyier : MonoBehaviour {

    public struct ColorButtonParams
    {
        public Color color;
        public int lambda { get; set; }
        public float circlesScale { get; set; }
    }

    public GameObject arrowContainer;

    public NewtonCirclesDrawer NewtonCirclesDrawer;

    public Text textLambda;

    private ColorButtonParams[] paramsCache;

	// Use this for initialization
	void Start () {
        Debug.Assert(NewtonCirclesDrawer, "NewtonCirclesDrawer of " + name + " is lost");
        Debug.Assert(arrowContainer, "arrowContainer of " + name + " is lost");


        paramsCache = new ColorButtonParams[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            ColorButtonParams colorButtonParams = new ColorButtonParams();

            Button button = transform.GetChild(i).GetComponent<Button>();

            colorButtonParams.color = button.GetComponent<Image>().color;
            colorButtonParams.lambda = button.GetComponent<ArrowColorParams>().lambdaValue;
            colorButtonParams.circlesScale = button.GetComponent<ArrowColorParams>().circlesScale;

            button.onClick.AddListener(() => ColorArrows(colorButtonParams));
            paramsCache[i] = colorButtonParams;
        }

        ColorArrows(paramsCache[Random.Range(0, paramsCache.Length)]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ColorArrows(ColorButtonParams colorButtonParams)
    {
        for(int i = 0; i < arrowContainer.transform.childCount; i++)
        {
            SpriteRenderer spriteRenderer = arrowContainer.transform.GetChild(i).GetComponent<SpriteRenderer>();
            if(spriteRenderer)
            {
                spriteRenderer.color = colorButtonParams.color;
            }
            else
            {
                arrowContainer.transform.GetChild(i).GetChild(0).GetComponent<SpriteRenderer>().color = colorButtonParams.color;
            }
        }

        if (textLambda)
            textLambda.text = "" + colorButtonParams.lambda;

        if (NewtonCirclesDrawer)
        {
            NewtonCirclesDrawer.lambda = colorButtonParams.lambda;
            NewtonCirclesDrawer.color = colorButtonParams.color;
            NewtonCirclesDrawer.ReinitCircleCanvas();
        }
    }
}
