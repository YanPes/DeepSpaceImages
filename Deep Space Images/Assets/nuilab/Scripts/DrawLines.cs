using UnityEngine;
using System.Collections;

public class DrawLines : MonoBehaviour
{
    [SerializeField]
    Texture2D ColorMap;

    [SerializeField]
    public int skip = 10;

    [SerializeField]
    float heightFactor = 10.0f, startWidth = 0.1f, endWidth = 0.1f, lineHeight = 0.1f;

    [SerializeField]
    Material mat;

	//-------------------------------------------------------------------
	void Start()
	    {
	        for (int x = 0; x < ColorMap.width; x += skip)
	        {
	            for (int z = 0; z < ColorMap.height; z += skip)
	            {
	                Color currentColor = ColorMap.GetPixel(x, z);
	                float currentHeight = ColorMap.GetPixel(x, z).grayscale;

	                Vector3 vertex = new Vector3(x * 0.1f, currentHeight * heightFactor, z * 0.1f);
	                Vector3 height = new Vector3(x * 0.1f, (currentHeight * heightFactor) + lineHeight, z * 0.1f);
	                Vector3[] lineVertices = new Vector3[] { vertex, height};

	                GameObject Pixel = new GameObject();
	                Pixel.transform.position = vertex;

	                LineRenderer DrawLine = Pixel.AddComponent<LineRenderer>();
	                DrawLine.SetPositions(lineVertices);
	                DrawLine.material = mat;
	                mat.color = currentColor;
	                DrawLine.SetWidth(startWidth, endWidth);
	                DrawLine.SetColors(currentColor, currentColor);
	            }
	        }
	    }
}