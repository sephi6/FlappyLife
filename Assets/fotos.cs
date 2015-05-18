using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class fotos : MonoBehaviour {

	// Use this for initialization
    public static Dictionary<string, Texture> fotosGuardadas= new Dictionary<string,Texture>();

    void Start()
    {
		if (FB.IsLoggedIn) {
			int random = Random.Range (0, FBHolder.urls.Count);
            if (FBHolder.urls.Count != 0 && !fotosGuardadas.ContainsKey(FBHolder.urls[random]))
            {

                StartCoroutine(cargaString(FBHolder.urls[random]));
                

            }
            else if (FBHolder.urls.Count != 0)
            {
                this.renderer.material.mainTexture=fotosGuardadas[FBHolder.urls[random]];
                Debug.Log("Foto reutilizada");
            }else{
            
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
        fotosGuardadas.Add(url, respuesta.texture);
        //fotosGuardadas[url] = respuesta.texture;
        this.renderer.material.mainTexture = respuesta.texture;
        Debug.Log("FOTO CARGADA: " + fotosGuardadas.Keys.Count);
    }
}

