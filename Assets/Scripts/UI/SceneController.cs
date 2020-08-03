using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Start" || SceneManager.GetActiveScene().name == "Game")
            GameStates.data.ToList().Where(o => o.name == "score").ToList().First().value = 0;
        foreach (ParticleSystem ps in GameObject.FindObjectsOfType<ParticleSystem>())
        {
            Destroy(ps);
        }
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    } 
}
