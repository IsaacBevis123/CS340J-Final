using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Spawning;

namespace MLAPI
{
    public class ConnectionApproval : MonoBehaviour
    {
        private int players = 1;

        private void Setup()
        {
            NetworkManager.Singleton.ConnectionApprovalCallback += ApprovalCheck;
            NetworkManager.Singleton.StartHost();
        }

        public void ApprovalCheck(byte[] connectionData, ulong clientId, MLAPI.NetworkManager.ConnectionApprovedDelegate callback)
        {
            Debug.Log("connectionData: " + connectionData);
            bool createPlayerObject = true;
            bool approve = true;
            players += 1;
            if (players > 5)
            {
                players = 1;
            }

            /*if (connectionData == System.Text.Encoding.ASCII.GetBytes("test")) // DANGER!!! This is magical duplicate code need a better way, but until then change line 28 of HostMenuScript
            {
                
                Debug.Log("Connection approved");
                approve = true;
                createPlayerObject = true;
            }*/

            // The prefab hash. Use null to use the default player prefab
            // If using this hash, replace "MyPrefabHashGenerator" with the name of a prefab added to the NetworkPrefabs field of your NetworkManager object in the scene
            ulong? prefabHash = NetworkSpawnManager.GetPrefabHashFromGenerator(("Player_" + players));

            Vector3 positionToSpawnAt = new Vector3(0, 0, 0);

            Quaternion rotationToSpawnWith = new Quaternion(0f, 0f, 0f, 0f);

            //If approve is true, the connection gets added. If it's false. The client gets disconnected
            callback(createPlayerObject, prefabHash, approve, positionToSpawnAt, rotationToSpawnWith);
        }
    }

}
