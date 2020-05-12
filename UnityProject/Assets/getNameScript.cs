﻿using System.Collections;
using System.Collections.Generic;
using Conectivitate.Authentication.Models;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class getNameScript : MonoBehaviour
{
    public Text nickname;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.LocalPlayer.NickName = nickname.text;
        nickname.text = AppUser.userName;
    }

    // Update is called once per frame
    void Update()
    {
        PhotonNetwork.LocalPlayer.NickName = nickname.text;
        nickname.text = AppUser.userName;
    }
}