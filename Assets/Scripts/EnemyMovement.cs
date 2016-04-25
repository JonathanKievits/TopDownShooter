using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    GameObject _playerGameobject;

    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent> ();
        _playerGameobject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        _navMeshAgent.SetDestination (_playerGameobject.transform.position);
    }
}
