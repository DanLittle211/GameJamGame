using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();
    public void AddItem(ItemObjects _item, int _amount)
    {
        bool hasItem = false;
        for(int i = 0; i < Container.Count; i++)
        {
            if(Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            Container.Add(new InventorySlot(_item, _amount));
        }
    }
    public void SubtractItem(ItemObjects _item, int _Amount)
    {
        for(int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].SubtractAmount(_Amount);
                break;
            }
        }
        for(int i = 0; i < Container.Count; i++)
        {
            if(Container[i].amount <= 0)
            {
                if(_item.name == "HealingPotion")
                {
                    Destroy(GameObject.Find("Image(Clone)"));
                }
                if (_item.name == "DanketsuBladePiece")
                {
                    Destroy(GameObject.Find("Image Varient 1(Clone)"));
                }
                if (_item.name == "DanketsuBladeTip")
                {
                    Destroy(GameObject.Find("Image Varient 2(Clone)"));
                }
                if (_item.name == "DanketsuHilt")
                {
                    Destroy(GameObject.Find("Image Varient 3(Clone)"));
                }
                if (_item.name == "Axe")
                {
                    Destroy(GameObject.Find("Image Varient 4(Clone)"));
                }
                if (_item.name == "Gauntlets")
                {
                    Destroy(GameObject.Find("Image Varient 5(Clone)"));
                }
                if (_item.name == "MagicTome")
                {
                    Destroy(GameObject.Find("Image Varient 6(Clone)"));
                }
                    Container.Remove(Container[i]);
            }    
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObjects item;
    public int amount;
    public InventorySlot(ItemObjects _item, int _amount)
    {
        item = _item;
        amount = _amount;

    }
    public void AddAmount(int value)
    {
        amount += value;
    }
    public void SubtractAmount(int value)
    {
        amount -= value;
    }
}
