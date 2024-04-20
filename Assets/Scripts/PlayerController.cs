using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;


public class PlayerController : MonoBehaviour
{
    NavMeshAgent _agent;
    [SerializeField] private Transform pricel;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        _agent.destination = pricel.position;
    }
}
