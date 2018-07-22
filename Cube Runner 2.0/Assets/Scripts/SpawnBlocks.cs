using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

	public GameObject StaticBlock;
	public GameObject FallingBlock;

	// Use this for initialization
	void Start () {
		StartCoroutine(Spawn());
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10 + Vector3.left, Color.red);
	}

	IEnumerator Spawn()
	{
		while (true)
		{
			//amount of static spawns
			for (int i = 0; i < 3; i++)
			{
				Vector3 spawn_position = transform.position + transform.TransformDirection(Vector3.forward) * Random.Range(30, 40) + Vector3.left * Random.Range(-20, 20);
				Instantiate(StaticBlock, spawn_position, Quaternion.identity);
			}
			//amount of falling spawns
			//TODO: Have falling blocks stop at ground,
			for (int i = 0; i < 1; i++)
			{
				Vector3 spawn_position = transform.position + transform.TransformDirection(Vector3.forward) * Random.Range(30, 40) + Vector3.left * Random.Range(-20, 20) + Vector3.up*10;
				Instantiate(FallingBlock, spawn_position, Quaternion.identity);
			}
			//frequency of spawns
			yield return new WaitForSeconds(.2f);
		}
	}
}
