using UnityEngine;

public class ControlItem : MonoBehaviour
{
    
    public static ControlItem Instance;

    Item item;

    public void BorrarItem()
    {
        ManagerInventario.Instance.Remover(item);
        Destroy(gameObject);
    }

    public void AgregarItem(Item NewItem)
    {
        item = NewItem;
    }


    public void UsarItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Medicina:
                Player_script.Instance.Curar(item.Valor);
                BorrarItem();
                break;

            case Item.ItemType.Arma:
                Player_script.Instance.ActivaArma();
                break;

        }

        
    }

   

    
    
}
