using UnityEngine;

public class Temporizador : MonoBehaviour
{
    public float TiempoMaximo;
    public float TiempoReset;

    public GameObject Linterna;
    public GameObject Linterna1;

    void Start()
    {

    }


    void Update()
    {
        Temp();


    }

    public void Temp()

    {

        TiempoMaximo = TiempoMaximo - Time.deltaTime;

        if(TiempoMaximo <= 0)
        {
            Linterna.SetActive(false);
            Linterna1.SetActive(false);
        }
        




    }
}
