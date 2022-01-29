using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNode : MonoBehaviour
{
	public GridType BlockType;

    [HideInInspector] public BlockDefs BD;

    private void Start()
    {
        BD = GameObject.FindGameObjectWithTag("BlockDefs").GetComponent<BlockDefs>();
    }

    public void Update()
    {
            RefreshBlockType(); // remove this update function and only call refreshBlockType from other scripts when the value in the array changes
    }

    public void RefreshBlockType()
    {
        GameObject tempObject = new GameObject();

        if (transform.parent.GetChild(1).childCount > 0)
            Destroy(transform.parent.GetChild(1).GetChild(0).gameObject);

        // need to add randomness and logic to prefab assigment below
        // need to also check for "lower" types

        if (BlockType == GridType.Air)
        {
            Destroy(tempObject);
            tempObject = Instantiate(BD.Blank[0], Vector3.zero, Quaternion.identity);
        }
        else if (BlockType == GridType.Building)
        {
            Destroy(tempObject);
            tempObject = Instantiate(BD.UpperBuildingSingle[0], Vector3.zero, Quaternion.identity);
        }
        else if (BlockType == GridType.GardenBox)
        {
            Destroy(tempObject);
            tempObject = Instantiate(BD.UpperGardenBox[0], Vector3.zero, Quaternion.identity);
        }
        else if (BlockType == GridType.Rubble)
        {
            Destroy(tempObject);
            tempObject = Instantiate(BD.UpperRubble[0], Vector3.zero, Quaternion.identity);
        }
        else if (BlockType == GridType.SmallTree)
        {
            Destroy(tempObject);
            tempObject = Instantiate(BD.UpperTreeLightTop[0], Vector3.zero, Quaternion.identity);
        }
        else if (BlockType == GridType.Tree)
        {
            Destroy(tempObject);
            tempObject = Instantiate(BD.UpperTreeTop[0], Vector3.zero, Quaternion.identity);
        }
        else if (BlockType == GridType.Bush)
        {
            Destroy(tempObject);
            tempObject = Instantiate(BD.UpperBush[0], Vector3.zero, Quaternion.identity);
        }

        tempObject.transform.position = transform.parent.GetChild(1).transform.position;
        tempObject.transform.SetParent(transform.parent.GetChild(1));
    }
}
