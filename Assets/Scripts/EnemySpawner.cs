using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject Enemy;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(EnemySpawn());
	}

    IEnumerator EnemySpawn()
    {
        while(true)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
