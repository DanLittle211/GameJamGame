using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Forest Enemy Object", menuName = "Enemy System/Forest/Bear")]
public class Bear : EnemyObjects
{
    public void Awake()
    {
        place = Location.Forest;
        StrengthScore = 8;
        MaxHealth = 30;
        CurrentHealth = MaxHealth;
    }
}
