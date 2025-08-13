using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UICondition : MonoBehaviour
{
    public Condition health;
    public Condition hunger;
    public Condition speed;
    public Condition jump;


    void Start()
    {
        CharacterManager.Instance.Player.condition.uiCondition = this;
    }
}


