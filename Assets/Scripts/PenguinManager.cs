using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenguinManager : MonoBehaviour
{
	public int penguinCounter = 0;
	public Text counterRenderer;

	// Start is called before the first frame update
	void Start()
    {
		 

	}

    // Update is called once per frame
    void Update()
    {
		counterRenderer.text = penguinCounter.ToString();


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
