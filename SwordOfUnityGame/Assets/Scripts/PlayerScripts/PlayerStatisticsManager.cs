using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStatisticsManager : MonoBehaviour
{
    #region Player Stats
    public int StrengthScore = 1;
    public int DexertityScore = 1;
    public int IntelegenceScore = 1;
    public int PlayerHealth = 6;
    public int currentHealth;
    #endregion
    #region Menu UI Elements
    public Text MaxHealth_MenuText;
    public Text StrScore_MenuText;
    public Text DexScore_MenuText;
    public Text IntScore_MenuText;
    public Text SkillPoints_Text;
    public InputField nameInput;
    public Button SP_ContinueButton;
    public Button Starting_ContinueButton;
    #endregion
    #region Combat Canvas UI Elements
    public Text CurrentHealth_Text;
    public Text StrTotal_Text;
    public Text DexTotal_Text;
    public Text IntTotal_Text;
    #endregion
    public string PlayerName;
    public byte SkillPoints = 14;
    // Update is called once per frame
    void Update()
    {
        //Updating Player's name based on what is input through the Input Field
        PlayerName = nameInput.text;
        // as long as the player has more than 0 skill points the button is disabled
        if(SkillPoints > 0)
        {
            SP_ContinueButton.interactable = false;
        }
        else
        {
            SP_ContinueButton.interactable = true;
        }
        // as long as player has not changed their name they can not continue
        if (nameInput.text == "")
        {
            Starting_ContinueButton.interactable = false;
        }
        else
        {
            Starting_ContinueButton.interactable = true;
        }
        // Updating Texts while things are being changed on the menu
        SkillPoints_Text.text = ("" + SkillPoints); //updates the ammount of skill points left
        MaxHealth_MenuText.text = ("" + PlayerHealth);//updates Player's current Maximum Health
        StrScore_MenuText.text = ("" + StrengthScore); //updates Player's current Strength score
        DexScore_MenuText.text = ("" + DexertityScore); //Updates Player's current Dexerity score 
        IntScore_MenuText.text = ("" + IntelegenceScore);//Updates Player's current Intelegence score
        // Updating Combat Canvas PLayer Stats texts
        CurrentHealth_Text.text = (currentHealth + "/" + PlayerHealth); // displays Player's current health total;
        StrTotal_Text.text = ("" + StrengthScore); // displays Player's strength score total
        DexTotal_Text.text = ("" + DexertityScore); // displays Player's dexerity score total
        IntTotal_Text.text = ("" + IntelegenceScore); // displays player's intelegence score total
        //Limits on how low the scores can go
        if(StrengthScore < 1)
        {
            StrengthScore = 1;
        }
        if(DexertityScore < 1)
        {
            DexertityScore = 1;
        } 
        if(IntelegenceScore < 1)
        {
            IntelegenceScore = 1;
        }
    }
    public void StrIncrease()
    {
        if(SkillPoints > 0)
        {
            StrengthScore += 1;
            SkillPoints -= 1;
        }
    }
    public void StrDecrease()
    { if(StrengthScore > 1)
        {
            StrengthScore -= 1;
            SkillPoints += 1;
        }  
    }
    public void DexIncrease()
    {
        if(SkillPoints > 0)
        {
            DexertityScore += 1;
            SkillPoints -= 1;
        }
    }
    public void DexDecrease()
    {
        if(DexertityScore > 1)
        {
            DexertityScore -= 1;
            SkillPoints += 1;
        }
    }
    public void IntIncrease()
    {
        if(SkillPoints > 0)
        {
            IntelegenceScore += 1;
            SkillPoints -= 1;
        }
    }
    public void IntDecrease()
    {
        if(IntelegenceScore > 1)
        {
            IntelegenceScore -= 1;
            SkillPoints += 1;
        }
    }
    public void HealthIncrease()
    {
        if(SkillPoints > 0)
        {
            PlayerHealth += 2;
            SkillPoints -= 1;
        }
    }
    public void HealthDecrease()
    {
        if(PlayerHealth > 6)
        {
            PlayerHealth -= 2;
            SkillPoints += 1;
        }
    }
    public void SetCurrenthealth()
    {
        currentHealth = PlayerHealth;
    }
}
