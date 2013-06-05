using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

    private Camera camara;
    private Vector3 origen;
    public float variacionx = 0.1f;
    public float variaciony = 0.05f;
    public float altura = 0;

    // Use this for initialization
	void Start ()
	{
	    this.camara = Camera.mainCamera;
	    origen = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
        var posx = origen.x + (camara.transform.position.x - origen.x) * (transform.position.z * variacionx);
        var posy = origen.y + (camara.transform.position.y - origen.y) * (transform.position.z * variaciony) + altura;
        transform.position = new Vector3(posx, posy, origen.z);
	}
}
