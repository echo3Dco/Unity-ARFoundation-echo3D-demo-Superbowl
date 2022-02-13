/**************************************************************************
* Copyright (C) echoAR, Inc. (dba "echo3D") 2018-2021.                    *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echo3D.co/terms, or another agreement                       *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    Rigidbody rb;

    [HideInInspector]
    public Entry entry;

    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    void Start()
    {

        // Add RemoteTransformations script to object and set its entry as long as this object is not named "Football.glb"
        // if (this.gameObject.name != "football-wilson.glb")
        // { 
            this.gameObject.AddComponent<RemoteTransformations>().entry = entry;
        // } 

        // Query additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }
    }

    void Update()
    {
       /* Removed TransformRotations from the imported projectile football
        
        * if (this.gameObject.name != "football-wilson.glb" && this.gameObject.GetComponent<RemoteTransformations>().enabled == true)
        {
            this.gameObject.AddComponent<RemoteTransformations>().enabled = false;
            
        } */ 
    }
}