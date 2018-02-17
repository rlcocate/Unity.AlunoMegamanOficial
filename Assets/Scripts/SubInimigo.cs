using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInimigo : MonoBehaviour {

	public float velocidade;
	public GameObject alvo;

	void Start () {

		// Atribui o alvo a ser perseguido.
		alvo = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		// Persegue o alvo.
		transform.position = Vector2.Lerp (
			transform.position,
			alvo.transform.position,
			velocidade * Time.deltaTime);

	}
}
