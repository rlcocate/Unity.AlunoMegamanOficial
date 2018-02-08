using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float velocidade;
	public float impulso;

	// Transform: Utilizado para obter informações do sensor.
	public Transform chaoVerificador;
	bool estaoNoChao;

	Animator animator;
	SpriteRenderer spriteRenderer;
	Rigidbody2D rb;

	void Start () {

		// Interface para os componentes.
		animator = GetComponent<Animator>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {

		// Movimentar.
		float mover_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);

		// Verificar colisão com o piso.
		estaoNoChao = Physics2D.Linecast(transform.position, chaoVerificador.position, 1 << LayerMask.NameToLayer("Piso"));

		// Pular.
		if (Input.GetButtonDown ("Jump") && estaoNoChao) {
			rb.velocity = new Vector2 (0.0f, impulso);
			animator.SetFloat ("pVertical", Input.GetAxisRaw ("Vertical"));
		} else {
			animator.SetFloat ("pVertical", Mathf.Abs (Input.GetAxisRaw ("Vertical")));
		}

		// Orientação.
		if (mover_x > 0) {
			spriteRenderer.flipX = false;
		} else if (mover_x < 0) {
			spriteRenderer.flipX = true;
		}

		animator.SetFloat ("pHorizontal", Mathf.Abs (Input.GetAxisRaw ("Horizontal")));
	}
}
