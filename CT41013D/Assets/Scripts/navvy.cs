using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navvy : MonoBehaviour{
    GameObject destination;
    NavMeshAgent agent;

    void Start() {
        destination = GameObject.Find("AgentTarget");    
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destination.transform.position);
    }
}
