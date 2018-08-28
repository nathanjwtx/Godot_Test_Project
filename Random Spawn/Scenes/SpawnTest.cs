using Godot;
using System;
using System.Collections.Generic;

public class SpawnTest : Node2D
{
    private static TileMap _spawn;
    private Random _rand;
    private int _enemyNumber = 2;
    private int _spawnCount = 4;
    private List<Vector2> _spawnPoints = new List<Vector2>();

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
            _spawnPoints.Add(usedCell);
        }
        GD.Print(_spawnPoints.Count);
    }

    public void SpawnBadGuys()
    {
        for (int i = 0; i < _enemyNumber; i++)
        {
            
        }
    }
}
