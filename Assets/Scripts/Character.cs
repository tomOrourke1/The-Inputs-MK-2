using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public State currentState;
    public InputActions inputActions;



    [SerializeField] private string name;






    public bool r1, r2, l1, l2;



    public void Start()
    {
        
        setState(new IdleState(this));



    }
    public void Awake()
    {
        inputActions = new InputActions();


        inputActions.Player.Enable();

        inputActions.Player.R1.performed += ctx => r1 = ctx.performed;
        inputActions.Player.R1.canceled += ctx => r1 = ctx.performed;

        inputActions.Player.R2.performed += ctx => r2 = ctx.performed;
        inputActions.Player.R2.canceled += ctx => r2 = ctx.performed;

        inputActions.Player.L1.performed += ctx => l1 = ctx.performed;
        inputActions.Player.L1.canceled += ctx => l1 = ctx.performed;

        inputActions.Player.L2.performed += ctx => l2 = ctx.performed;
        inputActions.Player.L2.canceled += ctx => l2 = ctx.performed;



    }
    public void Update()
    {
        currentState.Tick();

        Debug.Log("This would be R1: " + r1 + "R2: " + r2 + "L1: " + l1 + "l2: " + l2);

    }




    public void setState(State state)
    {
        if (currentState != null)
            currentState.OnStateExit();
        
        currentState = state;

        gameObject.name = name + " : " + state.GetType().Name;

        if (currentState != null)
            currentState.OnStateEnter();
    }

}

public abstract class State
{
    protected Character character;

    public abstract void Tick();

    public virtual void OnStateEnter() { }
    public virtual void OnStateExit() { }

    public State(Character character)
    {
        this.character = character;
    }

}

public class IdleState : State
{
    public IdleState(Character character) : base(character)
    {


    }

    public override void Tick()
    {

        if (character.r1 && !character.r2 && !character.l1 && !character.l2)
        {
            character.setState(new R1State(character));
        }
        else if (character.r2 && !character.r1 && !character.l1 && !character.l2)
        {
            character.setState(new R1State(character));
        }
        else if (character.l1 && !character.r2 && !character.r1 && !character.l2)
        {
            character.setState(new L1State(character));
        }
        else if (character.l2 && !character.r2 && !character.l1 && !character.r1)
        {
            character.setState(new L1State(character));
        }
        else
        {

        }

    }




}

public class R1State : State
{
    public R1State(Character character) : base(character)
    {
    }

    public override void Tick()
    {
        if(!character.r1)
        {
            character.setState(new IdleState(character));
        }






    }



}
public class R2State : State
{
    public R2State(Character character) : base(character)
    {
    }

    public override void Tick()
    {

        if (!character.r2)
        {
            character.setState(new IdleState(character));
        }





    }



}

public class L1State : State
{
    public L1State(Character character) : base(character)
    {
    }

    public override void Tick()
    {
        if (!character.l1)
        {
            character.setState(new IdleState(character));
        }






    }



}
public class L2State : State
{
    public L2State(Character character) : base(character)
    {
    }

    public override void Tick()
    {

        if (!character.l2)
        {
            character.setState(new IdleState(character));
        }





    }



}

