﻿/**
 * 
 * Created by DUWAFARM on 27/10/17.
 * Copyright © 2017. All rights reserved.
 * 
 **/
using UnityEngine;

public class DesactivarTextoAmpliarTiempo : MonoBehaviour {

	ControladorJuego controller;
	void Start () {
		controller = GameObject.Find ("ControladorJuego").GetComponent<ControladorJuego> ();
	}
	
	public void DesactivateTextoAmpliarTiempo(){
		this.gameObject.SetActive (false);
		controller.MoreTime ();
	}
}