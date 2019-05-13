﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Placenote;

public class GameControllerTutorial : PlacenotePunMultiplayerBehaviour
{
    protected override void OnGameStart()
    {
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity, 0);
        PhotonNetwork.Instantiate("SampleMoon", Vector3.zero, Quaternion.identity, 0);
        PhotonNetwork.Instantiate("ProteinStructureParent", Vector3.zero, Quaternion.identity, 0);

    }
}
