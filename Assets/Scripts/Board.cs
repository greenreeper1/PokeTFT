using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Object;

public class Board : NetworkBehaviour
{
    [SerializeField]
    private int width = 7;
    [SerializeField]
    private int height = 4;
    [SerializeField]
    private Tile tilePrefab;
    [SerializeField]
    private float tileRadius = 1f;

    private Tile[][] tiles;

    override public void OnStartServer()
    {
        base.OnStartServer();
        GenerateBoard();
    }
    private void GenerateBoard()
    {
        tiles = new Tile[width][];
        float xOffset = 100 * tileRadius * Mathf.Sqrt(3f);
        float zOffset = 100 * tileRadius * 1.5f;

        for (int x = 0; x < width; x++)
        {
            tiles[x] = new Tile[height];

            for (int y = 0; y < height; y++)
            {
                float xPos = x * xOffset + (y % 2 == 0 ? 0 : xOffset / 2);
                float zPos = y * zOffset;

                Tile newTile = Instantiate(tilePrefab, new Vector3(xPos, 0, zPos), Quaternion.identity, transform);
                newTile.Initialize(new Vector2(x, y));

                tiles[x][y] = newTile;
            }
        }
    }
}
