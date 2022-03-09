using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jaimporte, lai lietotu visus I interfeisus
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	// Velkamajam objektam piestiprinátá komponente
	private CanvasGroup kanvasGrupa;
	//Priekś parvietojamá objekta atraśanás vietas uzglabáśanas
	private RectTransform velkObjRectTransf;
	//Norade uz objektu skriptu
	public Objekti objektuSkripts;

	// Use this for initialization
	void Start () {
		//Pieklust objekta pastiprinátajai CanvasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup>();
		//Pieklust objekta recttrasform komponentei
		velkObjRectTransf = GetComponent<RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Uzklikśḱináts uz velkama objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta vilkśana");
		//Velkot objektu tas paliek caurspidigs
		kanvasGrupa.alpha = 0.6f;
		//Lai objektam velkot iet cauri raycast stari
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek vilkśana");
		//Maina objekta x, y koordinates
		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;


	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beigta objekta vilkśana");
		kanvasGrupa.alpha = 1f;

		//Ja objekts nebija nolikts istaja vieta
		if (objektuSkripts.vaiIstajaVieta == false) {
			//tad atkal to var vilkt
			kanvasGrupa.blocksRaycasts = true;
			//Ja nolikts istaja vieta
		} else {
			//aizmirst pedejo objektu kas vilkts
			objektuSkripts.pedejaisVilktais = null;
		}
		//Ja viens objekts nolikts istaja vita tad varetu turpinat vilkt parejos
		//iestata uz false
		objektuSkripts.vaiIstajaVieta = false;
	}
}