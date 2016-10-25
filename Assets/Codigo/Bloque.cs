using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {

	public GameObject efectoParticulas; //

	public Puntos puntos; 

	void OnCollisionEnter() // Se llama en Is Trigger desactivado
	{
		
		Instantiate (efectoParticulas, transform.position, Quaternion.identity);
		Destroy (gameObject);
		transform.SetParent (null); 
		puntos.GanarPunto (); 
	}

}
