using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Player Object
    public GameObject Player;
    #endregion
    #region Script References
    public GameStateManager State_Mang;
    public CombatManager CombatManager;
    #endregion
    // Update is called once per frame
    void Update()
    {

        ///Player Movement Stuff///
        ///As long as the world state is the Overworld_State, the player can move
        if(State_Mang.currentWorldState == GameStateManager.WorldState.Overworld_State)
        {
            //Moving left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Player.transform.Translate(-0.01f, 0f, 0f);
            }
            //Moving Right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Player.transform.Translate(0.01f, 0f, 0f);
            }
            //Moving Up
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                Player.transform.Translate(0f, 0.01f, 0f);
            }
            //Moving Down
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                Player.transform.Translate(0f, -0.01f, 0f);
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            State_Mang.currentWorldState = GameStateManager.WorldState.Combat_State;
        }
        if(collision.gameObject.name == "Enemy_Snake")
        {
            CombatManager.currentEnemy = CombatManager.whichEnemy.Snake;
        }
    }
}