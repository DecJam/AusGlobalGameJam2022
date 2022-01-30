using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNode : MonoBehaviour
{
	public GridType BlockType = GridType.Building;

  //  [HideInInspector] public BlockDefs BD;

    private void Start()
    {
        //BD = GameObject.FindGameObjectWithTag("BlockDefs").GetComponent<BlockDefs>();
    }

    public void Update()
    {
          //  RefreshBlockType(); // remove this update function and only call refreshBlockType from other scripts when the value in the array changes
    }

    public void RefreshBlockType(bool up)
    {
        GameObject tempObject;

        if (transform.parent.GetChild(1).childCount > 0)
            Destroy(transform.parent.GetChild(1).GetChild(0).gameObject);
		if (true)
		{
            Quaternion rot = Quaternion.identity;

			if (!up)
			{
                rot = Quaternion.Euler(0, 0, -180);
			}
        // need to add randomness and logic to prefab assigment below
        // need to also check for "lower" types
        BlockDefs BD = BlockDefs.Instance;
        if (BlockType == GridType.Air)
        {
            //Destroy(tempObject);
            tempObject = Instantiate(BD.Blank[0], Vector3.zero, rot); 
        }
        else if (BlockType == GridType.Building)
        {
            //Destroy(tempObject);
            tempObject = Instantiate(BD.UpperBuildingSingle[0], Vector3.zero, rot);
        }
        else if (BlockType == GridType.GardenBox)
        {
            //Destroy(tempObject);
            tempObject = Instantiate(BD.UpperGardenBox[0], Vector3.zero, rot);
        }
        else if (BlockType == GridType.Rubble)
        {
            //Destroy(tempObject);
            tempObject = Instantiate(BD.UpperRubble[0], Vector3.zero, rot);
        }
        else if (BlockType == GridType.SmallTree)
        {
            //Destroy(tempObject);
            tempObject = Instantiate(BD.UpperTreeLightTop[0], Vector3.zero, rot);
        }
        else if (BlockType == GridType.Tree)
        {
            //Destroy(tempObject);
            tempObject = Instantiate(BD.UpperTreeTop[0], Vector3.zero,  rot);
        }
        else if (BlockType == GridType.Bush)
        {
            //Destroy(tempObject);
            tempObject = Instantiate(BD.UpperBush[0], Vector3.zero, rot);
        }
			else
			{
                tempObject = Instantiate(BD.Blank[0], Vector3.zero, rot);
            }
            SetParent(tempObject);
       
		}
       //Debug.Log("RefreshBlockType");
    }

    private void SetParent(GameObject obj)
	{
        obj.transform.position = transform.parent.GetChild(1).transform.position;
        obj.transform.SetParent(transform.parent.GetChild(1));
    }
}
