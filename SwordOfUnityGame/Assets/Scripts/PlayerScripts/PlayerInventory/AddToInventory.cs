using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInventory : MonoBehaviour
{
    public InventoryObject inventory;
    #region Item Prefabs
    public ItemObjects HealingPotion;
    public ItemObjects Axe;
    public ItemObjects Gauntlets;
    public ItemObjects MagicTome;
    public ItemObjects DanketsuBladePiece;
    public ItemObjects DanketsuBladeTip;
    public ItemObjects DanketsuHilt;
    #endregion
    //Adding Items to Inventory
    public void AddHealingPot()
    {
        inventory.AddItem(HealingPotion, 1);
    }
    public void AddAxe()
    {
        inventory.AddItem(Axe, 1);
    }
    public void AddGauntlets()
    {
        inventory.AddItem(Gauntlets, 1);
    }
    public void AddTome()
    {
        inventory.AddItem(MagicTome, 1);
    }
    public void AddDanketsuBP()
    {
        inventory.AddItem(DanketsuBladePiece, 1);
    }
    public void AddDanketsuBT()
    {
        inventory.AddItem(DanketsuBladeTip, 1);
    }
    public void AddDanketsuHilt()
    {
        inventory.AddItem(DanketsuHilt, 1);
    }
    //Using Items
    public void UseHealingPot()
    {
        inventory.SubtractItem(HealingPotion, 1);
    }
}
