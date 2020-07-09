using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NPCType { Farmer, Beggar, ShopOwner }


public interface INPC
{
    void Speak();

}

