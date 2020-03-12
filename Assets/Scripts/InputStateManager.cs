using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputStateManager : MonoBehaviour
{
    private InputActions inputActions;
    private InputActions.PlayerActions playerInput;

    public string currentStateName;
    public List<string> lastInputs = new List<string>();
    
    public InputState currentState;
    
    public void SetState(InputState state)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
            lastInputs.Add(currentState.action.name);
        }

        currentState = state;
        currentStateName = currentState.action.name;
        

        if (currentState != null)
            currentState.OnStateEnter();
    }

    public void UpdateInput()
    {
                
    }

    public void IncomingInput(InputAction.CallbackContext context)
    {
        SetState(new InputState(this, context.action));
    }

    private void Update()
    {
        UpdateInput();
    }

    private void Awake()
    {
        inputActions = new InputActions();
        inputActions.Player.Enable();

        this.playerInput = inputActions.Player;

        playerInput.R1.performed += IncomingInput;
        playerInput.R2.performed += IncomingInput;
        playerInput.L1.performed += IncomingInput;
        playerInput.L2.performed += IncomingInput;
        
    }
}

public class InputState : State
{
    public InputAction action;
    protected InputStateManager StateManager;
    
    public InputState(InputStateManager stateManager, InputAction action)
    {
        this.action = action;
        this.StateManager = stateManager;

        this.action.canceled += ExitState;
    }

    private void ExitState(InputAction.CallbackContext obj)
    {
        Debug.Log(action.name + " was just released");
    }

    public override void Tick()
    {
        
    }
    
}