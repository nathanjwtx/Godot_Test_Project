using Godot;
using System;

public class Scene1 : Node2D
{
    [Export] public PackedScene Character;

    public override void _Ready()
    {
        var test = (SpriteScene) Character.Instance();
        var test1 = new SpriteScene();
        var pos = GetNode<Position2D> ("Position2D");
        test.Position = new Vector2(pos.Position.x, pos.Position.y);
        test.SetSpriteName("Bob");
        test1.SetSpriteName("Bill");
        GD.Print(test.SpriteName);
        GD.Print(test1.SpriteName);
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
