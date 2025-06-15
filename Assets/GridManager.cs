using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public List<GameObject> grids = new List<GameObject>();

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void PlaceGrid(Vector3 pos)
    {
        int gridIndex = UnityEngine.Random.Range(0, grids.Count);
        Instantiate(grids[gridIndex], pos, Quaternion.identity, this.transform);
    }

}
