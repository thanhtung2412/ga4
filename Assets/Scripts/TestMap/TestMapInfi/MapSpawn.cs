using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawn : MonoBehaviour
{
    [SerializeField] protected Vector3 spawnPosOffset = new Vector3(0, 0, 0);
    public MapParent mapParent;
    public CheckMap checkMap;
    private void Awake()
    {
        mapParent = transform.parent.GetComponentInParent<MapParent>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!checkMap.isMap)
            {
                SpawnMap();
            }
        }
    }
    protected virtual void SpawnMap()
    {       
        Vector3 spawnpos = mapParent.transform.position;
        spawnpos.x += this.spawnPosOffset.x;
        spawnpos.y += this.spawnPosOffset.y;
        spawnpos.z += this.spawnPosOffset.z;

        GameObject newmap = Instantiate(this.mapParent.transform.gameObject);
        newmap.transform.position = spawnpos;
       

    }

}
