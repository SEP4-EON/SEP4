using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinKiller : MonoBehaviour
{
	public ParticleSystem bloodSplatt;

	public AudioSource deathScream;

	public AudioSource PortalSound;

	public GameObject penguinManagerGameObject;

	public PenguinManager penguinManagerComponent;

	public CapsuleCollider penguCollider;

	public MeshRenderer penguRenderer;

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

	public void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("PenguinKiller"))
		{
			bloodSplatt.Play();
			deathScream.Play();
			penguCollider.enabled = false;
			penguRenderer.enabled = false;
			penguinManagerComponent.CountPenguin(1, true);
			Destroy(this.gameObject,2f);
		}

		if (collision.gameObject.CompareTag("PenguinGoal"))
		{
			PortalSound.Play();
			penguinManagerComponent.CountPenguin(1, false);
		}
	}
	
}
