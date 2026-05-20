using Godot;
using System;
using System.Text.Json.Serialization.Metadata;

public partial class GameManager : Node
{
	public static string Version = "0.0.1";

	public static PlayerDataClass PlayerData = new PlayerDataClass();

	public override void _Ready()
	{
		GD.Print("GameManager initialized");
		PlayerData.Init();

		string JSONString = System.Text.Json.JsonSerializer.Serialize(PlayerData);
		GD.Print(JSONString);
	}
}
