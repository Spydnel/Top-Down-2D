using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    struct tileData
    {
        int i, j;

        private tileData(int a, int b)
        {
            i = a;
            j = b;
        }
    }

    public List<tileData> tileList = new List<tileData>
    {
        new tileData(0, 0),
        new tileData(1, 1),
        new tileData(2, 2)
    };

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
