using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class nomesanasVieta : MonoBehaviour, IDropHandler {
	//Uzglabat velkama objekta un nomesanas lauka z rotaciju, 
	// kaari rotacijas un izmeru starpibu
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm; 

	public Objekti objektuSkripts;

	//Nostrádas, ja objektu vensas nomest uz jebkuras nomjesanas vietas
	public void OnDrop(PointerEventData notikums){
		//Parbauda vai tika vilkts un atlaists vispar kads objekts
		if(notikums.pointerDrag != null){
			//ja nomesanas vietas sakrit ar vilkta obj tagu
			if(notikums.pointerDrag.tag.Equals(tag)) {
			//iegust objekta rotaciju grados
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform>().eulerAngles.z;
				//aprekina abu objektu z rotacijas starpibu
				rotacijasStarpiba = Mathf.Abs(vietasZrot - velkObjZrot);
				//lidzigi ka ar z rotaciju piefikse objekti izmeri pa x un y asim ka ari stapriba
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform>().localScale;
				velkObjIzm = GetComponent<RectTransform>().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);


				//Parbauda vai objektu rotacijas un izmeru starpiba ir pielaujamas robezas
				if((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <=360))
					&& (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1 )){
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts smuki iecentrejas nomesanas lauka
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition 
					= GetComponent<RectTransform> ().anchoredPosition;
					//rotacijai
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation
					= GetComponent<RectTransform> ().localRotation;
					//izmeram
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale
					= GetComponent<RectTransform> ().localScale;

					//Parbauda tagu un skanas atbilstoso skanas effektu
					switch(notikums.pointerDrag.tag){
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[1]);
						break;
					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[2]);
						break;
					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[3]);
						break;
					case "b2tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[4]);
						break;
					case "CementaMasinaTag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[5]);
						break;
					case "e46Tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[6]);
						break;
					case "Policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[7]);
						break;
					case "EskavatorsTag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[8]);
						break;
					case "Traktors1Tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[9]);
						break;
					case "Traktors5Tag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[10]);
						break;
					case "UgunsdzesejiTag":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot[11]);
						break;
					

					default:
						Debug.Log ("Nedefinets tags!");
						break;
		}
	}
				//Ja objekts nomests nepareizaja lauka
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [0]);

				//objektu aizmet uz sakotnejo poziciju
				//Parbauda tagu un skanas atbilstoso skanas effektu
				switch(notikums.pointerDrag.tag){
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.atkrKoord;
					break;
				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.atroKoord;
					break;
				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.bussKoord;
					break;
				case "b2tag":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.b2Koord;
					break;
				case "CementaMasinaTag":
					objektuSkripts.CementaMasina.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.CementaMasinaKoord;
					break;
				case "e46Tag":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.e46Koord;
					break;
				case "Policija":
					objektuSkripts.Policija.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.PolicijaKoord;
					break;
				case "EskavatorsTag":
					objektuSkripts.Eskavators.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.EskKoord;
					break;
				case "Trak1Tag":
					objektuSkripts.Traktors1.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.Trak1Koord;
					break;
				case "Trak5Tag":
					objektuSkripts.Traktors5.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.Trak5Koord;
					break;
				case "UgunsdzesejiTag":
					objektuSkripts.Ugunsdzeseji.GetComponent<RectTransform> ().localPosition
					= objektuSkripts.UgunsKoord;
					break;

				default:
					Debug.Log ("Nedefinets tags!");
					break;
				}
			}
		}
	}
}
