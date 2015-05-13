using UnityEngine;
using System.Collections;

public class fotos : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
		if (FB.IsLoggedIn) {
			int random = Random.Range (0, FBHolder.urls.Count);
			if (FBHolder.urls.Count != 0) {
				StartCoroutine (cargaString (FBHolder.urls [random]));
			} else {
				Debug.LogWarning ("No tenemos url");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator cargaString(string url)
    {
        Debug.Log("Cargando url... " + url);
        WWW respuesta = new WWW(url);
        //tras la siguiente linea, esta rutina quedara en pausa y el hilo principal se sigue ejecutando hasta que la url este cargada
        yield return respuesta;
        //ya tenemos la url, podemos hacer con ella lo que queramos
        //this.stringAModificar = respuesta.text;
        this.renderer.material.mainTexture = respuesta.texture;
        Debug.Log("FOTO CARGADA");
    }
}
