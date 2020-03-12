using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class Character : MonoBehaviour
{
    //public State currentState;
    
    [SerializeField] private string name;

    //public bool r1, r2, l1, l2;
    
    // Manage Transitions between input states

    public void Awake()
    {
        
    }

}


// Manages the Player's State of Input, allows us to read things like combos








public abstract class State
{

    public abstract void Tick();

    public virtual void OnStateEnter()
    {
        
    }

    public virtual void OnStateExit()
    {
        
    }

    public State()
    {
 
    }

}



