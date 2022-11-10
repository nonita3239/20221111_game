using UnityEngine;

namespace ZY
{
    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FireSystembase : MonoBehaviour

    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點物")]
        private Transform pointSpawn;

        protected void SpawnBullet()
        { 
        Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
