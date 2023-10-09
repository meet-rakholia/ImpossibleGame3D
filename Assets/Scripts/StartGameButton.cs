using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Quaternion = System.Numerics.Quaternion;

namespace DefaultNamespace
{
    public class StartGameButton : MonoBehaviour
    {
        public void HoverStart()
        {
            transform.localScale = Vector3.one * 1.1f;
        }
        public void HoverEnd()
        {
            transform.localScale = Vector3.one;
        }
        public void ClickStart()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.gray;
        }
        public void ClickEnd()
        {
            MeshRenderer mr = GetComponent<MeshRenderer>();
            mr.material.color = Color.white;
        }

        public void FixedUpdate()
        {
            transform.Rotate(0.5f,0.5f,0.5f);
        }

        public void Click()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}