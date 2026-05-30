using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public Item item;

    public void PickUp()
    {
        ManagerInventario.Instance.Agregar(item);
        Destroy(gameObject);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            PickUp();
            ManagerInventario.Instance.ItemEnlistado();
        }
    }
        
    
}
