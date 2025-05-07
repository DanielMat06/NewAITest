using UnityEngine;
using UnityEngine.AI;

public class NewEnemyScript : MonoBehaviour
{
    public float distance;
    public Transform Player;

    public NavMeshAgent navMeshAgent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, Player.position);

        if (distance < 10)
        {
            navMeshAgent.destination = Player.position;
        }
    }
}
