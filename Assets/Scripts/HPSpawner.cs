using UnityEngine;
using System.Collections;

public class HPSpawner : MonoBehaviour {

    public GameObject HPUP;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            Instantiate(HPUP, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(60f);
        }
    }
}
