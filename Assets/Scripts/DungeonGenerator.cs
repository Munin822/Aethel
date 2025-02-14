using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public int dungeonWidth;
    public int dungeonHeight;
    public GameObject floorTile;
    public GameObject wallTile;

    void Start()
    {
        GenerateDungeon();
    }

    void GenerateDungeon()
    {
        for (int x = 0; x < dungeonWidth; x++)
        {
            for (int y = 0; y < dungeonHeight; y++)
            {
                GameObject tile = Instantiate(floorTile, new Vector3(x, y, 0), Quaternion.identity);
                tile.transform.SetParent(this.transform);
            }
        }

        // Add walls around the dungeon
        for (int x = -1; x <= dungeonWidth; x++)
        {
            Instantiate(wallTile, new Vector3(x, -1, 0), Quaternion.identity).transform.SetParent(this.transform);
            Instantiate(wallTile, new Vector3(x, dungeonHeight, 0), Quaternion.identity).transform.SetParent(this.transform);
        }
        for (int y = -1; y <= dungeonHeight; y++)
        {
            Instantiate(wallTile, new Vector3(-1, y, 0), Quaternion.identity).transform.SetParent(this.transform);
            Instantiate(wallTile, new Vector3(dungeonWidth, y, 0), Quaternion.identity).transform.SetParent(this.transform);
        }
    }
}