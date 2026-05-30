using UnityEngine;
using UnityEngine.AI;

public class EnemigoNaveMesh : MonoBehaviour
{
    public float RadioPrincipal;
    public Transform PointerPlayer;
    public NavMeshAgent Agent;
    public float RadioGolpe;
    public Animator AnimatorEnemy;

    public GameObject HandCollider1;
    public GameObject HandCollider2;


    void Start()
    {
        AnimatorEnemy = GetComponentInChildren<Animator>();   
    }

    
    void Update()
    {
        MovimientoNaveMesh();
    }

    public void MovimientoNaveMesh()
    {
        float Distancia = Vector3.Distance(PointerPlayer.position, transform.position);

        if (Distancia <= RadioPrincipal)
        {
            Agent.SetDestination(PointerPlayer.position);
            Agent.speed = 0.8f;
            AnimatorEnemy.SetBool("Walk", true);

            if(Distancia <= RadioGolpe)
            {
                AnimatorEnemy.SetBool("Golpe", true);
                Agent.speed = 0;

            }
            else
            {
                AnimatorEnemy.SetBool("Golpe", false);
            }

        }

        else
        {
            AnimatorEnemy.SetBool("Walk", false);
            Agent.speed = 0;
        }


    }

    

}
