using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NuttonRandomColor : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void GameExit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Start()
    {
        List<Color> colors = new List<Color>();
        colors.Add(new Color32(113, 198, 253, 1));
        colors.Add(new Color32(240, 200, 47, 1));
        colors.Add(Color.magenta);
        GetComponent<Button>().image.color = colors[Random.Range(0, colors.Count)] + Color.white/2;
    }
}
