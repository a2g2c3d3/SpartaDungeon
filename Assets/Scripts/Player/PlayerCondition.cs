using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;
    
    Condition health { get { return uiCondition.health; } }
    Condition hunger { get { return uiCondition.hunger; } }

    public float veryHungerDamage;

    void Update()
    {
        hunger.Subtract(hunger.passiveValue * Time.deltaTime);

        if (hunger.curValue <= 0f){
            health.Subtract(veryHungerDamage*Time.deltaTime);
        }

        if (health.curValue <= 0f) 
        {
            Die();
        }

    }

    public void Die()
    {
        Debug.Log("ав╬З╢ы!");
    }
}
