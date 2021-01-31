using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Cave Enemy Object", menuName = "Enemy System/Cave/Lich")]
public class Lich : EnemyObjects
{
    public void Awake()
    {
        place = Location.Cave;
        IntelegenceScore = 12;
        MaxHealth = 50;
        CurrentHealth = MaxHealth;
    }
}
