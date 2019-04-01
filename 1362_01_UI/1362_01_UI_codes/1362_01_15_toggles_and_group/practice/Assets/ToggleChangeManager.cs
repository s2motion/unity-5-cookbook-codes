using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleChangeManager : MonoBehaviour {

  private Toggle toggle;

	// Use this for initialization
	void Start () {
	 toggle = GetComponent<Toggle>();
	}

	// Update is called once per frame
	public void PrintNewToggleValue() {
		bool status = toggle.isOn;

    print("toggle status = " + status);
	}
}
