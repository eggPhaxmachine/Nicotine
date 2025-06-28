using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreInstatiate
{

    public GameObject prefab;
    public GameObject instance;
    
    public Vector3 startingPos = new Vector3();
    public Quaternion startingRotation = new Quaternion();

    public RectTransform parent = null;


    public PreInstatiate(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public PreInstatiate(GameObject prefab, Vector3 startingPos)
    {
        this.prefab = prefab;
        this.startingPos = startingPos;
    }

    public PreInstatiate(GameObject prefab, Vector3 startingPos, Quaternion startingRotation)
    {
        this.prefab = prefab;
        this.startingPos = startingPos;
        this.startingRotation = startingRotation;
    }

    public PreInstatiate withParent(RectTransform parent)
    {
        this.parent = parent;
        return this;
    }

    public GameObject get()
    {
        if (instance == null)
        {
            GameObject.Instantiate(prefab, startingPos, startingRotation, parent);
        }

        return instance;
    }
    
    

    public static implicit operator GameObject(PreInstatiate gameObject)
    {
        if (gameObject.instance == null)
        {
            GameObject.Instantiate(gameObject.prefab, gameObject.startingPos, gameObject.startingRotation, gameObject.parent);
        }

        return gameObject.instance;
    }
}
