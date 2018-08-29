using Godot;
using System;
using System.Collections.Generic;

public class SpawnTest : Node2D
{
    [Export] public PackedScene Star;
    
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
        SpawnBadGuys();
    }

    public void GetSpawnCells()
    {
        foreach (Vector2 usedCell in _spawn.GetUsedCells())
        {
            _spawnPoints.Add(usedCell);
        }

    }

    public void SpawnBadGuys()
    {
        for (int i = _enemyNumber; i > 0; i--)
        {
            var point = _rand.Next(0, _enemyNumber);
            SpawnStar s = (SpawnStar) Star.Instance();
            s.Position = _spawn.MapToWorld(_spawnPoints[point]) + _spawn.CellSize / 2; 
            AddChild(s);
            _spawnPoints.Remove(_spawnPoints[point]);
        }
    }
}
