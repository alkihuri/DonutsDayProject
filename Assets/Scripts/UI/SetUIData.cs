using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SetUIData : MonoBehaviour
{
    public string variable;
    public string label;
    // Start is called before the first frame update
    void Update()
    {
        
        GetComponent<Text>().text = label + " " + GameStates.data.ToList().Where(o => o.name == variable).ToList().First().value;
    }
     
}
