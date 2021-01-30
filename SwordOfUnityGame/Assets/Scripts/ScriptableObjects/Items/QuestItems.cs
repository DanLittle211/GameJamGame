using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Quest Object", menuName = "Inventory System/Items/Quest_Item")]
public class QuestItems : ItemObjects
{
    public void Awake()
    {
        type = ItemType.QuestItem;
    }
}
