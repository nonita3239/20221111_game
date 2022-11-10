using UnityEngine;

namespace ZY
{
    /// <summary>
    /// �o�g�t�ΰ�
    /// </summary>
    public class FireSystembase : MonoBehaviour

    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I��")]
        private Transform pointSpawn;

        protected void SpawnBullet()
        { 
        Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
