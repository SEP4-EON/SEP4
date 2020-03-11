using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinManager : MonoBehaviour
{
	public int penguinCounter = 0;

	// Start is called before the first frame update
	void Start()
    {
		 

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void CountPenguin(int amountToCount, bool toBeSubtracted)
	{
		if (toBeSubtracted)
		{
			penguinCounter -= amountToCount;
		}
		else
		{
			penguinCounter += amountToCount;
		}
	}
}
