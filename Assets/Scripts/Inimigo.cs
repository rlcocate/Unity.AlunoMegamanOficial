using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

	public int vidas;
	public GameObject peixePrefab;
	public Transform gerarPeixes;
	public float intervalo;

	IEnumerator Start () {

		// Gera os peixes que sairam da boca do inimigo.
		Instantiate (peixePrefab, 
			gerarPeixes.position, 
			gerarPeixes.rotation);
		yield return new WaitForSeconds (intervalo);
		StartCoroutine (Start ());
	}
	
	// 
	void OnCollisionEnter2D (Collision2D c) {

		// Subtrai vida quando for atingido pelo projetil.
		if (c.gameObject.tag == "Projetil") {

			vidas--;

			// Destroi inimigo quando encerrar as vidas.
			if (vidas <= 0) {
				Destroy (gameObject);
			}
		}
	}
}
