﻿using UnityEngine;
using System.Collections;
public class ReturnBack : MonoBehaviour {
	public void OnClick(){
		Debug.Log ("Clicked");
		Application.LoadLevel (0);
	}
}
