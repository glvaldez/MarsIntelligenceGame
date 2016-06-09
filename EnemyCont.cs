using UnityEngine;
using System.Collections;

public class EnemyCont : MonoBehaviour
{
    // public Transform goal;
    private Transform player;
    private NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();

    }
        //Once the yellow orb is grabbed, the enemies will start attacking the player
    void Update()
         {
        if ((Orb.yellowGrabbed == true))
        {
            agent.SetDestination(player.position);
        }
    }


}