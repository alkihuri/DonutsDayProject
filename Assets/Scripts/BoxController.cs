using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }
    float moveValue;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.transform.gameObject);
        GameStates.data.ToList().Where(o => o.name == "score").ToList()[0].AddPoint();
        GameObject.FindObjectOfType<CameraController>().ShakeCamera();
    }
    // Update is called once per frame
    void Update()
    {
        //moveValue =  Input.GetAxis("Mouse X");
        moveValue = Input.GetTouch(0).deltaPosition.x;
        if(Mathf.Abs(transform.position.x)<2.5)
        {
            transform.position = Vector3.Slerp(transform.position, startPosition, 0.1f);
        }
        transform.Translate(moveValue/100, 0, 0);
    }
}
