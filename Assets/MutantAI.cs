using UnityEngine;
using UnityEngine.AI;

public class MutantAI : MonoBehaviour
{

    public NavMeshAgent Agent2;
    public Animator AnimatorMutant;
    public float RadioGlobal;
    public float RadioMorder;
    public Transform PointerPlayer;

    public GameObject Mutante1;
    public GameObject MutanteReal;


    

    void Start()
    {
        AnimatorMutant = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        MovimientoMutant();
    }


    public void MovimientoMutant()
    {
        Agent2.SetDestination(PointerPlayer.position);
        Agent2.speed = 0.9f;
        AnimatorMutant.SetBool("Walk", true);

        float Distancia = Vector3.Distance(PointerPlayer.position, transform.position);

        if (Distancia <= RadioMorder)
        {
            AnimatorMutant.SetBool("Bite", true);
            Agent2.speed = 0;

        }
        else
        {
            AnimatorMutant.SetBool("Bite", false);
        }


    }


    public void ActivarMutante()
    {

        Mutante1.SetActive(false);
        MutanteReal.SetActive(true);

    }


}
