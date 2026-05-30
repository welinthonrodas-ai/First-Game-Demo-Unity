using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ManagerInventario : MonoBehaviour
{
    public static ManagerInventario Instance;

    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public ControlItem[] InventarioItem;

    private void Awake()
    {
        Instance = this;
    }

    public void Agregar(Item Item)

    {
        Items.Add(Item);
    }

    public void Remover(Item Item)
    {
        Items.Remove(Item);

    }

    public void ItemEnlistado()

    {
        foreach (Transform Item in ItemContent)
        {
            Destroy(Item.gameObject);
        }



        foreach (var item in Items)
        {
            GameObject Obj = Instantiate(InventoryItem, ItemContent);

            ControlItem Control = Obj.GetComponent<ControlItem>();
            Control.AgregarItem(item);

            var ItemName = Obj.transform.Find("ItemName").GetComponent<Text>();
            var IconName = Obj.transform.Find("Icon").GetComponent<Image>();

            ItemName.text = item.ItemName;
            IconName.sprite = item.Icon;

        }

    }

    
}
