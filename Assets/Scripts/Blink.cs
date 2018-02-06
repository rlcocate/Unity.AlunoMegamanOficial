using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour {

	public float intervalo;

	IEnumerator Start () {

		// Obtem o componente do objeto.
		//GetComponent<SpriteRenderer> ().enabled = false;
		//yield return new WaitForSeconds (intervalo);
		//GetComponent<SpriteRenderer> ().enabled = true;
		//yield return new WaitForSeconds (intervalo);

		// Obtem o componente do objeto (Faz o mesmo que o de cima, de forma reduzida).
		GetComponent<SpriteRenderer> ().enabled = !GetComponent<SpriteRenderer> ().enabled;
		yield return new WaitForSeconds (intervalo);

		// Faz a chamada novamente do método, deixando-o em looping (Recursividade).
		StartCoroutine (Start ());
	}

	void Update(){

		// Pressionar enter.
		if (Input.GetKeyDown(KeyCode.Return)) {
			SceneManager.LoadScene ("game-scene");
		}
	}
}
