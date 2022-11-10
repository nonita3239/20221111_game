using UnityEngine;

namespace ZY
{
    /// <summary>
    /// 
    /// </summary>

    public class CharacterController : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField] private Sprite Picturemiddle;

        private void Update()
        {
            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");
            print("<color=red>玩家上下按鍵:" + v + "/color");
            transform.Translate(speedHorizontal * Time.deltaTime*h, speedVertical * Time.deltaTime*v,0);
        }


    }
}