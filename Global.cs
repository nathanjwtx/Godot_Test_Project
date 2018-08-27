using Godot;
using System;

public class Global : Node
{
    public string PlayerName;

    public override void _Ready()
    {
        Viewport root = GetTree().GetRoot();
        
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
