using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglaba aina esoso kanvu
	public Canvas kanva;
	//GameObject, kas uzglabas velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject CementaMasina;
	public GameObject e46;
	public GameObject Policija;
	public GameObject Eskavators;
	public GameObject Traktors1;

	//Uzglaba velkamo objektu sakotnejas atrasanas vietas koordinatas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 CementaMasinaKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 PolicijaKoord;
	[HideInInspector]
	public Vector2 EskKoord;
	[HideInInspector]
	public Vector2 Trak1Koord;

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
		atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
		b2Koord = b2.GetComponent<RectTransform>().localPosition;
		CementaMasinaKoord = CementaMasina.GetComponent<RectTransform>().localPosition;
		e46Koord = e46.GetComponent<RectTransform>().localPosition;
		PolicijaKoord = Policija.GetComponent<RectTransform>().localPosition;
		EskKoord = Eskavators.GetComponent<RectTransform>().localPosition;
		Trak1Koord = Traktors1.GetComponent<RectTransform>().localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
