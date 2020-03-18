using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTrap : MonoBehaviour
{
	

	private GameObject penguinManagerGameObject;
	private PenguinManager penguinManagerComponent;

	// Start is called before the first frame update
	void Start()
    {
		penguinManagerGameObject = GameObject.FindWithTag("PenguinManager");
		penguinManagerComponent = penguinManagerGameObject.GetComponent<PenguinManager>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Penguin"))
		{
			penguinManagerComponent.CountPenguin(1, true);
		}
	}
}
