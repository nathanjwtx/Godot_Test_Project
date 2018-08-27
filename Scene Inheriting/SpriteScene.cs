using Godot;
using System;

public class SpriteScene : Node2D
{
    public string SpriteName;

    public override void _Ready()
    {
        
    }

    public void SetSpriteName(string _name)
    {
        SpriteName = _name;
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
