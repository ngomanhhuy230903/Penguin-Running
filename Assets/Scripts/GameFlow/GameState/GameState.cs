using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    protected GameManager brain;
    private void Awake()
    {
        brain = GetComponent<GameManager>();
    }
    public virtual void Construct()
    {

       Debug.Log("GameState Constructed");
    }
    public virtual void Destruct()
    {
        Debug.Log("GameState Destructed");
    }
    public virtual void UpdateState()
    {
        Debug.Log("GameState Updated");
    }
}
