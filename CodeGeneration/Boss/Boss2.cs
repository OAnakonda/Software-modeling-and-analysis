
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Boss2 : Boss {

    public Boss2() {
    }

    private BossPhase currentPhase = Boss2Phase;

    private BossMovement movement = Boss2Movement;

    private string backgroundMusic;

    private string banner;

    private Items dropItem;

    private bool isDefeated;

}