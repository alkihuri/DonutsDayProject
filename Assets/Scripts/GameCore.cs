using System.Collections; 
using UnityEngine;
using Unity.Collections;
using System.Linq;

public class GameCore : MonoBehaviour
{
    public GameObject donught;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        GameStates.GameInit();
        StartCoroutine(DonughtSpawn());
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.transform.gameObject);
        GameStates.data.ToList().Where(o => o.name == "score").ToList().First().AddPoint(-1);
        if (GameStates.data.ToList().Where(o => o.name == "score").ToList().First().value ==0)
        {
            GameObject.FindObjectOfType<SceneController>().LoadScene("Finish");
        }
    }
    IEnumerator DonughtSpawn()
    {
        while(1==1)
        {
            Vector3 randomPos = new Vector3(Random.Range(-2,2) , 0, 0);
            GameObject newDonught = Instantiate(donught, spawnPoint.position + randomPos, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
}
