using Godot;
using System;

public class PlayerDataClass
{
    public string GameVersion {get; set;} = GameManager.Version;

    public void Init()
    {
        GD.Print("Initializing Player Data");
    }
}
