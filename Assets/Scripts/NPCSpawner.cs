using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_ShopOwner;

    public void SpawnVillagers()
    {
        /** we don't want to specify the class to instiate for each type of 
         * villager.
         * Instead, we ask the factory to "manufactuarte" it for us.
         */
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_ShopOwner = m_Factory.GetNPC(NPCType.Shopowner);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_ShopOwner.Speak();
    }
}