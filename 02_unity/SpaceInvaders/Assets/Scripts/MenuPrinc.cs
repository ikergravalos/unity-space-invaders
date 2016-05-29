using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPrinc : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void jugadorOne()
    {
        SceneManager.LoadScene(0);
    }

    public void jugadorTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void menuInicio()
    {
        SceneManager.LoadScene(1);
    }

    public void salir()
    {
        Application.Quit();
    }
}
