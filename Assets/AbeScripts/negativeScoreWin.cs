using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class negativeScoreWin : MonoBehaviour
{
    //The enemy's health
    public int enemyHealth = 100;
    // Playground's UI object
    public UIScript uiScript;
    //TMP Text that holds the score
    public TextMeshProUGUI enemyHPText;
    //Does this enemy's death trigger the "You Win" screen?
    public bool triggersGameOver = false;
    //The whole UI component for this enemy
    public GameObject thisEnemyUI;


     void Start()
    {
        //Set the enemy health in the UI
        enemyHPText.text = enemyHealth.ToString();
    }


    public void takeDamage(int damagePerHit)
    {
        //Take points from enemy and update UI
        enemyHealth -= damagePerHit;
        enemyHPText.text = enemyHealth.ToString();

        //If the enemy's health reaches 0
        if (enemyHealth <= 0)
        {
            //Trigger "You Win" if selected
            if (triggersGameOver)
            {
                uiScript.GameWon(0);
            }

            //turn off UI Element
            thisEnemyUI.SetActive(false);
            //Destroy the object
            Destroy(gameObject);
        }
    }


}
