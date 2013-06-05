using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    public float variacion = 0.1f;
    private Camera camara;
    private GameObject target;
    public float maxposy;
    public float minposy;

	// Use this for initialization
	void Start ()
	{
	    this.camara = GetComponent<Camera>();
	    this.target = GameObject.FindGameObjectWithTag("Player");
	}
	
	void FixedUpdate ()
	{
	    float z = camara.transform.position.z;
        Vector3 pos = target.transform.position * variacion + camara.transform.position * (1 - variacion);
        camara.transform.position = new Vector3(pos.x, Mathf.Clamp(pos.y, minposy, maxposy), z);
	}
}
