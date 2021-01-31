using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maim : HybridAttacks
{
    public int Damage;
    public Bear bear;
    private void Awake()
    {
        A_Type = AttackType.Hybrid;
    }
    public void doMaim()
    {
        Debug.Log("Bear used Maim");
    }
}
