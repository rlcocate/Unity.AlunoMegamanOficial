using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ControleTouch : MonoBehaviour {

	public float velocidade;

	// Update is called once per frame
	void Update () {
		float mover_x = CrossPlatformInputManager.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;		
		float mover_y = CrossPlatformInputManager.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;
	}
}
