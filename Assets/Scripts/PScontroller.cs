using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PScontroller : MonoBehaviour
{
    private void OnDestroy()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        if(!GetComponent<ParticleSystem>().IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
