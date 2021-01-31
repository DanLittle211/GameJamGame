using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Cave Enemy Object", menuName = "Enemy System/Cave/Draugr")]
public class Draugr : EnemyObjects
{
    public void Awake()
    {
        place = Location.Cave;
        StrengthScore = 8;
        MaxHealth = 30;
        CurrentHealth = MaxHealth;
    }
}
