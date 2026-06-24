using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenuInicio : MonoBehaviour
{


    public GameObject MenuInicio;
    public GameObject Configuracion;
    
   public void CargaEscena()

    {
        SceneManager.LoadScene(1);
    }
    
    
    public void CerrarConfig()
    {
        MenuInicio.SetActive(true);
        Configuracion.SetActive(false);
    }

    public void CerrarMenuInicio()
    {
        MenuInicio.SetActive(false);
        Configuracion.SetActive(true);
    }


}
