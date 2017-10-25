using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorMovement : MonoBehaviour {

	public float speed = 5;
	public float waveDistance;
	[SerializeField]public Shader projectionAdditiveShader;

	private Material mat;
	private Projector waveProjector;
	private Color colorValue;

	void Start() {
		waveProjector = gameObject.GetComponent<Projector> ();
		mat = new Material (waveProjector.material.shader);
		mat.CopyPropertiesFromMaterial (waveProjector.material);
		waveProjector.material = mat;
		colorValue = new Color (mat.color.r, mat.color.g, mat.color.b);


	}

	// Update is called once per frame
	void Update () {
		gameObject.transform.SetPositionAndRotation (
			new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + (Time.deltaTime * speed), gameObject.transform.position.z), 
			gameObject.transform.rotation);
		waveProjector.material.color = new Color (colorValue.r < 0.0f ? 0.0f : colorValue.r-=(1.0f/waveDistance), 
			colorValue.g < 0.0f ? 0.0f : colorValue.g-=(1.0f/waveDistance), 
			colorValue.b < 0.0f ? 0.0f : colorValue.b-=(1.0f/waveDistance));

		if (colorValue.r == 0 && colorValue.g == 0 && colorValue.b == 0)
			Destroy (gameObject);
	}
}
