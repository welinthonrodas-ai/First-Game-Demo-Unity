using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/CreateNewItem")]
public class Item : ScriptableObject
{

    public string ItemName;
    public int Valor;
    public Sprite Icon;


    public ItemType itemType;
    public enum ItemType
    {
        Arma,
        Medicina,
        Objeto,

    };

}
