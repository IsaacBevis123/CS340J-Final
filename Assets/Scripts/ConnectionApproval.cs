using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using MLAPI.Spawning;

namespace MLAPI
{
    public class ConnectionApproval : MonoBehaviour
    {
        private void Setup()
        {
            NetworkManager.Singleton.ConnectionApprovalCallback += ApprovalCheck;
            NetworkManager.Singleton.StartHost();
        }

        private void ApprovalCheck(byte[] connectionData, ulong clientId, MLAPI.NetworkManager.ConnectionApprovedDelegate callback)
        {
            //Your logic here
            bool approve = true;
            bool createPlayerObject = true;

            // The prefab hash. Use null to use the default player prefab
            // If using this hash, replace "MyPrefabHashGenerator" with the name of a prefab added to the NetworkPrefabs field of your NetworkManager object in the scene
            //ulong? prefabHash = SpawnManager.GetPrefabHashFromGenerator("MyPrefabHashGenerator"); <-- SpawnManager doesn't exist in this context but it should, need to figure this out.

            Vector3 positionToSpawnAt = new Vector3(0, 0, 0);

            Quaternion rotationToSpawnWith = new Quaternion(0f, 0f, 0f, 0f);

            //If approve is true, the connection gets added. If it's false. The client gets disconnected
            callback(createPlayerObject, null /*<-- should be prefabHash*/, approve, positionToSpawnAt, rotationToSpawnWith);
        }
    }

}
