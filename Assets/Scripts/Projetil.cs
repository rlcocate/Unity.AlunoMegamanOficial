using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {
		// Destroi o projetil (após 3 segundos) caso não acerte nada.
		Destroy (gameObject, 3.0f);
	}

	void OnCollisionEnter2D(Collision2D c){
		// Destroi o projetil por colisão.
		Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D c) {

		// Destroi o sub inimigo.
		if (c.tag == "SubInimigo") {
			Destroy (c.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		// Mover o projetil.
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
	}
}
