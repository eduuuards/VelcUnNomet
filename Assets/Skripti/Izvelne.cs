using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Izvelne : MonoBehaviour {

	// Use this for initialization
	public void uzSpeli(){
		SceneManager.LoadScene ("PilsetasAina", LoadSceneMode.Single);
		
	}
}
