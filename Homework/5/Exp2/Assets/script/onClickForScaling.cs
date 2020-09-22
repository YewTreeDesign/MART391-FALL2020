using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class onClickForScaling : MonoBehaviour {
	void OnMouseDown() {
		CSharpscaling.ScaleTransform = this.transform;
	}
}