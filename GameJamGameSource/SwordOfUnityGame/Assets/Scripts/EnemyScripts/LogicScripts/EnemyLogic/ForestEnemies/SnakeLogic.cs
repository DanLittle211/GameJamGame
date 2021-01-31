using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeLogic : MonoBehaviour
{
    public float currentAttack;
    public CombatManager combatManager;
    private void Awake()
    {
        combatManager = GameObject.Find("GameManager").GetComponent<CombatManager>();
    }
    private void Update()
    {
       
    }
    public void chooseAttack()
    {
       currentAttack = Mathf.Round(Random.Range(1, 7));
        Debug.Log("Snake Chose: " + currentAttack);
    }
    public void doAttack()
    {
        Debug.Log("Snake Attacked");
        combatManager.EnemyWent = true;
    }
}
