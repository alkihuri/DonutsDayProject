using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 startPosition;
    public bool shakeCamera;
    public float timeForShaking = 0.4f;

    List<Color> colors = new List<Color>();



    private void Start()
    {
        colors.Add(new Color32(113, 198, 253,1));
        colors.Add(new Color32(240, 200, 47, 1));
        colors.Add(Color.magenta);
        startPosition = transform.position;
        shakeCamera = false;
    }
    private void Update()
    {
        double   scoreChange = GameStates.data.ToList().Where(o => o.name == "score").ToList()[0].value;
         
        if (shakeCamera)
        {
           
            Handheld.Vibrate();
            transform.position = startPosition + new Vector3(Random.Range(-1, 1) * Mathf.Sin(Time.time) / 10, Random.Range(-1, 1) * Mathf.Sin(Time.time) / 10, 0);
        }
    }


    IEnumerator SetShaking ()
    {
        shakeCamera = true; 
        GetComponent<Camera>().backgroundColor = colors[Random.Range(0, colors.Count)];
        yield return new WaitForSeconds(timeForShaking);
        shakeCamera = false; 
        transform.position = startPosition;
    }
    public void ShakeCamera()
    {
        StartCoroutine(SetShaking());
    }
}
