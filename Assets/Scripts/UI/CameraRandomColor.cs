using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRandomColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        List<Color> colors = new List<Color>();
        colors.Add(new Color32(113, 198, 253, 1));
        colors.Add(new Color32(240, 200, 47, 1));
        colors.Add(Color.magenta);
        GetComponent<Camera>().backgroundColor = colors[Random.Range(0, colors.Count)];
    }

     
}
