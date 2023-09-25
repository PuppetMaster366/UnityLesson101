using NavMeshPlus.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(AgentOverride2d))]
[RequireComponent(typeof(AgentRotate2d))]
public class Mover : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

	private void Awake()
	{
        agent = GetComponent<NavMeshAgent>();
	}

	// Update is called once per frame
	void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //the agent will search a path and start moving towards the Pos.
            agent.SetDestination(mouseWorldPosition);
        }
       
    }
    public void SetMovementTarget(Vector2 position)
    {
        agent.isStopped = false;
        agent.SetDestination(position);
    }

    public void CancelMovement()
    {
        agent.isStopped = true;
    }

    public Vector2 GetPosition()
    {
        return transform.position;
    }
}
