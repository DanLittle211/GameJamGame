using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Weapon/Axe")]
public class Axe : WeaponItem
{
    public void Awake()
    {
        type = ItemType.Weapon;
        pStatsMang = GameObject.Find("GameManager").GetComponent<PlayerStatisticsManager>();
        Damage = pStatsMang.StrengthScore;
    }
}
