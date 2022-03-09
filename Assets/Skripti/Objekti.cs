﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglaba aina esoso kanvu
	public Canvas kanva;
	//GameObject, kas uzglabas velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	//Uzglaba velkamo objektu sakotnejas atrasanas vietas koordinatas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	//Uzglabas audio avotu kura atskanot attelu skanas efektus
	public AudioSource skanasAvots;
	//Masivs, kas uzglaba visas iespejamas skanas
	public AudioClip[] skanaKoAtskanot;
	//mainigais piefiksa vai ista vieta objektam
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//uzglabas pedejo objektu kurs pakustinats
	public GameObject pedejaisVilktais = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
