
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class User : IFireBaseClient {

    public User() {
    }

    public int userId;

    private string userName;

    private string userPwd;

    private float inGameProggress;

    private int inGameTime;

    private Dictionary<string, dynamic> locationProggress;

    private Dictionary<string, dynamic> bossProggress;

    private Dictionary<string, dynamic> deathStatistic;

    private Dictionary<string, dynamic> hitsStatistic;

    /// <summary>
    /// @return
    /// </summary>
    private int UserCreation() {
        // TODO implement here
        return 0;
    }

    /// <summary>
    /// @return
    /// </summary>
    private int UserAuthorization() {
        // TODO implement here
        return 0;
    }

    /// <summary>
    /// @return
    /// </summary>
    private FireBaseConfig GetConectionToDb() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void SaveGameProggres() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void SaveGameTime() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void SaveLocationProggress() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void SaveBossProggress() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void SaveDeathStatistic() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    private void SaveHitsStatistic() {
        // TODO implement here
        return null;
    }

}