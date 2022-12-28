
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Boss1 : Boss {

    public Boss1() {
    }

    private BossPhase currentPhase = Boss1Phase;

    private BossMovement movement = Boss1Movement;

    private string backgroundMusic;

    private string banner;

    private Items dropItem;

    private bool isDefeated;

}