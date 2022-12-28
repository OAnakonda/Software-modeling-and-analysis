
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Boss : MonoBehaviour {

    public Boss() {
    }

    public Transform player;

    public bool isFlipped = false;

    private BossPhase currentPhase;

    private BossMovement movement;

    private string backgroundMusic;

    private string banner;

    private Items dropItem;

    private bool isDefeated;

    /// <summary>
    /// @return
    /// </summary>
    public void LookAtPlayer() {
        // TODO implement here
        return null;
    }

}