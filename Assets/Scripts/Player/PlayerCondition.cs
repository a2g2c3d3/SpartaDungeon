using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;
    public Action inventory;
    public PlayerController controller;

    Condition health { get { return uiCondition.health; } }
    Condition hunger { get { return uiCondition.hunger; } }

    public float veryHungerDamage;
    private void Awake()
    {

    }
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
    public void Heal(float amount)
    {
        health.Add(amount);
    }

    public void Eat(float amount)
    {
        hunger.Add(amount);
    }

    public void IncreaseSpeed(float amount)
    {
        CharacterManager.Instance.Player.controller.moveSpeed += amount; // 실제 속도

    }

    public void IncreaseJump(float amount)
    {
        CharacterManager.Instance.Player.controller.jumpPower += amount; // 실제 속도
    }

    public void Die()
    {
        Debug.Log("죽었다!");
    }
}
