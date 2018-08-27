using Godot;
using System;

public class Player : Node2D
{
    private Global _g;

    public override void _Ready()
    {
        _g = (Global) GetNode("/root/Global");
		_g.PlayerName = "nathan";
        GetMyName();
    }

    public void GetMyName()
    {
        GD.Print(_g.PlayerName);
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
