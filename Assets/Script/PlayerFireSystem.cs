using UnityEngine;

namespace ZY
{
    /// <summary>
    /// ���a�o�g�t��
    /// </summary>
    public class PlayerFireSystem : FireSystembase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }

    }
}
