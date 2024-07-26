﻿using UnityEngine;
using System.Collections;

public class AppBootStrap : MonoBehaviour
{
  public bool buildForCardboard = false;
  public bool isMainScene = false;
  public GameObject cameraFadeScreenPrefab;
  public GameObject cardboardCameraPrefab;
  public GameObject oculusCameraPrefab;
  public GameObject reticlePrefab;
  public GameObject lookdownMenuPrefab;
  public GameObject lookdownNotifierPrefab;
  public GameObject mainScenePrefab;
  public GameObject mountainPrefab;
  public GameObject forestPrefab;

  // singleton access
  void Awake()
  {
    // does an AppCentral Already exist?
    AppCentral app = UnityEngine.Object.FindObjectOfType<AppCentral>();

    if (app == null)
    {
      GameObject appGameObj = new GameObject("AppCentral");

      // match bootstraps location and rotation
      appGameObj.transform.position = transform.position;
      appGameObj.transform.rotation = transform.rotation;

      // add appcentral
      app = appGameObj.AddComponent<AppCentral>();
      app.buildForCardboard = buildForCardboard;
      app.cardboardCameraPrefab = cardboardCameraPrefab;
      app.oculusCameraPrefab = oculusCameraPrefab;
      app.reticlePrefab = reticlePrefab;
      app.lookdownMenuPrefab = lookdownMenuPrefab;
      app.lookdownNotifierPrefab = lookdownNotifierPrefab;
      app.cameraFadeScreenPrefab = cameraFadeScreenPrefab;
      app.mainScenePrefab = mainScenePrefab;
      app.isMainScene = isMainScene;
      app.mountainPrefab = mountainPrefab;
      app.forestPrefab = forestPrefab;
      app.Initialize();
    }

    // we are done
    Destroy(gameObject);
  }

}
