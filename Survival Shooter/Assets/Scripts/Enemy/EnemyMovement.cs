using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent nav;


    public void Awake ()
    {
        //Cari game
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //Mendapatkan Reference component
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();

    }


    public void Update ()
    {
        //Memindahkan posisi playerf
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)        
        {
             nav.SetDestination (player.position);
        }
        else //Hentikan moving
        {
            nav.enabled = false;
        }
    }
}
