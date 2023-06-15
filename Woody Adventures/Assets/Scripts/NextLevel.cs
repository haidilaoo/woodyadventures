using UnityEngine;
using UnityEngine.SceneManagement; 
 
 public class NextLevel : MonoBehaviour
 {
      [SerializeField]
      private string _level2 = "Level2";
      void OnMouseDown ()
      {
          SceneManager.LoadScene(_level2);
      }
 }