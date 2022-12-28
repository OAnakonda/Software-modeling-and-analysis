
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Player : ColliderExpand {

    public Player() {
    }

    private RigidBody2D rb;

    private SpriteRenderer spriteRenderer;

    public attackPoint Transform;

    public float runSpeed;

    public float jumpSpead;

    private bool isGrounded;

    private bool isMoving;

    public string Name;

    private Animator animator;

    private Transform GroundCheck;

    private Transform GroundCheck_L;

    private Transform GroundCheck_R;

    /// <summary>
    /// @return
    /// </summary>
    private void Start() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void Update() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void dash() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void LoadPlayer() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void SavePlayer() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void LoadName() {
        // TODO implement here
        return null;
    }

}