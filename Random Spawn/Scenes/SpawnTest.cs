using Godot;
using System;

public class SpawnTest : Node2D
{
    private static TileMap _spawn;
    private Random _rand;

    public override void _Ready()
    {
        _rand = new Random();
        _spawn = GetNode<TileMap>("Spawn");
        GetSpawnCells();
    }

    public void GetSpawnCells()
    {
        foreach (Vector2 usedCell in _spawn.GetUsedCells())
        {
            GD.Print(usedCell);
        }
    }
}
