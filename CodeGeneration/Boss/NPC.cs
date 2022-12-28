
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NPC : MonoBehaviour{

    public NPC() {
    }

    private int maxHealth;

    private GameObject currentEntity;

    private int currentHealth;

    private Vector3 startPosition;

    private bool isInvincible;

    private float detectRange;

    private Transform player;

    private bool isFlipped;

    private string name;

    /// <summary>
    /// @param amount 
    /// @return
    /// </summary>
    public void TakeDamage(int amount) {
        // TODO implement here
        return null;
    }

    public void Operation1() {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public void Die() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void DamageAnimation() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void LookAtPlayer() {
        // TODO implement here
        return null;
    }

}