
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BossMovement : StateMachineBehaviour {

    public BossMovement() {
    }

    private Transform player;

    private Transform boss;

    internal void leftBarrier;

    private PoligonCollider2D arena;

    private RigidBody2D rb;

    private float speed;

    internal float nextAttackTime;

    /// <summary>
    /// @param animator 
    /// @param stateInfo 
    /// @param layerIndex 
    /// @return
    /// </summary>
    public void OnStateEnter(void animator, void stateInfo, int layerIndex) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param animator 
    /// @param stateInfo 
    /// @param layerIndex 
    /// @return
    /// </summary>
    public void OnStateUpdate(void animator, void stateInfo, int layerIndex) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param animator 
    /// @param stateInfo 
    /// @param layerIndex 
    /// @return
    /// </summary>
    public void OnStateExit(void animator, void stateInfo, int layerIndex) {
        // TODO implement here
        return null;
    }

}