using Godot;
using System;

public class SpawnStar : Area2D
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        
    }

    public void Init(Vector2 pos)
    {
//        Texture texture = (Texture) GD.Load("res://Random Spawn/Assets/star.png");
        GD.Print(pos);
        Position = pos;
    }
}
