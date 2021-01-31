using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Location { Forest, Cave, Castle }
public class EnemyObjects : ScriptableObject
{
    public GameObject prefab;
    public Location place;
    public byte StrengthScore;
    public byte DexerityScore;
    public byte IntelegenceScore;
    public byte MaxHealth;
    public byte CurrentHealth;
}
