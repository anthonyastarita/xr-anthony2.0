using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Placenote;

public class ProteinStructureController : MonoBehaviour
{
    void Start()
    {
        // Register this object to the current game controller.
        // This is important so that all clients have a reference to this object.
        //GameController.Instance.RegisterMoon(this);
    }
}
