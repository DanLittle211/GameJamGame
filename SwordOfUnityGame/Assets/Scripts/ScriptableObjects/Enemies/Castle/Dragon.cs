using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Castle Enemy Object", menuName = "Enemy System/Castle/Dragon")]
public class Dragon : EnemyObjects
{
    public void Awake()
    {
        place = Location.Castle;
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
        IntelegenceScore = 20;
    }
}
