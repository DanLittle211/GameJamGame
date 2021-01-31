using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Forest Enemy Object", menuName = "Enemy System/Forest/Wolf")]
public class Wolf : EnemyObjects
{
    public void Awake()
    {
        place = Location.Forest;
        IntelegenceScore = 4;
        MaxHealth = 18;
        CurrentHealth = MaxHealth;
    }
}
