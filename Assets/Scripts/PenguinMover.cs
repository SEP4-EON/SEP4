﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PenguinMover : MonoBehaviour
{
	public GameObject moveHere;
	private NavMeshAgent agent;

	// Start is called before the first frame update
	void Start()
	{
		moveHere = GameObject.FindWithTag("PenguinTarget");
		agent = GetComponent<NavMeshAgent>();
	}

	// Update is called once per frame
	void Update()
	{

		agent.SetDestination(moveHere.transform.position);

	}
	
}
