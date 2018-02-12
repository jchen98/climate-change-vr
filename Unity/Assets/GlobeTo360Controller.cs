using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeTo360Controller : MonoBehaviour {

	public CameraObrbit cameraOrbit;
	public Skybox skybox;
	public Camera camera;
	public GameObject earthGameObject;

	public void Toggle360Mode(bool enable)
	{
		cameraOrbit.enabled = enable; //!enable
		skybox.enabled = enable;
		camera.clearFlags = enable ? CameraClearFlags.Skybox : CameraClearFlags.Color;
		earthGameObject.SetActive (!enable);
	}
}
