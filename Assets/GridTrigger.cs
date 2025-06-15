using System;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class GridTrigger : MonoBehaviour
{
    public GridManager gridManager;
    public float sizeX = 10f;
    private void Start()
    {
        gridManager = GetComponentInParent<GridManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("a");
        if (collision != null && collision.transform.tag == "Player")
        {
            Debug.Log("b");
            Debug.Log(transform.position.x);
            Debug.Log(transform.position.x + sizeX);
            gridManager.PlaceGrid(new Vector3(transform.position.x + sizeX - transform.localPosition.x, 0.3257618f, 0));
        }
    }

}
