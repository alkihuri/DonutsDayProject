using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonughtController : MonoBehaviour
{
    public GameObject ps;
    private void OnDestroy()
    {
        Instantiate(ps, transform.position, transform.rotation);
    }
    private void Start()
    {
        GetComponentInChildren<Light>().color = Random.ColorHSV();
    }
    public void OnDonughtClickEvent()
    {
        Debug.Log("lalalalal");
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        

        transform.Rotate(Random.Range(-10, 10),0, Random.Range(-10, 10));
    }
}
