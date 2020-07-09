using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CNPCFactory : MonoBehaviour
{
   public INPC GetNPC(NPCType typeNpc)
    {
        switch (typeNpc)
        {
             case NPCType.Beggar : return new CBeggar();
             case NPCType.Farmer:return new CFarmer();
             case NPCType.ShopOwner:return new CShopowner();
             default: return null;
        }
       
    }
}
