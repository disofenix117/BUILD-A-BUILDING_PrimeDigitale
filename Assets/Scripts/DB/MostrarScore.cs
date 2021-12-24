using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarScore : MonoBehaviour
{


    string MostrarNombre="https://prime-pruebasweb.com/rankingstack/MostrarNombre.php";
  string mostrarScore="https://prime-pruebasweb.com/rankingstack/MostrarScore.php";
   string MostrarTiempo="https://prime-pruebasweb.com/rankingstack/MostrarTiempo.php";
   /*
    string MostrarNombre="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Stacks/Scores/MostrarNombre.php";
   string mostrarScore="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Stacks/Scores/MostrarScore.php";
   string MostrarTiempo="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Stacks/Scores/MostrarTiempo.php";
*/
     void Awake()
    {
        Ranking();
        
    }

public void Ranking()
{
    StartCoroutine("mostrar");
}
     IEnumerator mostrar()
   {
       Text tabla=GameObject.FindGameObjectWithTag("Tabla").GetComponent<Text>();
       Text tabla1=GameObject.FindGameObjectWithTag("Tabla1").GetComponent<Text>();
       Text tabla2=GameObject.FindGameObjectWithTag("Tabla2").GetComponent<Text>();
       WWW recibirN =new WWW(MostrarNombre);
       WWW recibirS =new WWW(mostrarScore);
       WWW recibirT =new WWW(MostrarTiempo);

       yield return recibirN;
       yield return recibirS;
       yield return recibirT;

       tabla.text=recibirN.text;
       tabla1.text=recibirS.text;
       tabla2.text=recibirT.text;

       yield return new WaitForSeconds(2);



   }
}
