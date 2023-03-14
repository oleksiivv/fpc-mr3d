using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTextManagement : MonoBehaviour
{

  public Text[] introText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (PlayerPrefs.GetString("Language") == "Eng")
      {
        introText[0].GetComponent<Text>().text="The government has developed a special quest to train new super-soldiers.";

        introText[1].GetComponent<Text>().text="You are the first experimental.";

        introText[2].GetComponent<Text>().text="But remember that Government will kill everyone who won't complete the quest to avoid divulging secret experiment";

        introText[3].GetComponent<Text>().text="Good luck";




      }


      else if (PlayerPrefs.GetString("Language") == "Ukr")
      {
        introText[0].GetComponent<Text>().text="Уряд розробив спеціальний квест для підготовки нових супер-солдатів.";

        introText[1].GetComponent<Text>().text="Ви перший піддослідний";

        introText[2].GetComponent<Text>().text="Але пам'ятайте, уряд вб'є всіх, хто не завершить квест, щоб уникнути розголошення таємного експерименту";

        introText[3].GetComponent<Text>().text="Щасти";



      }

      else if (PlayerPrefs.GetString("Language") == "Esp")
      {

        introText[0].GetComponent <Text>().text = "El gobierno ha desarrollado una misión especial para entrenar nuevos super-soldados.";

        introText[1].GetComponent <Text>().text = "Eres el primer experimental.";

        introText[2].GetComponent <Text>().text = "Pero recuerde que el Gobierno matará a todos los que no completen la misión para evitar divulgar el experimento secreto";

        introText[3].GetComponent <Text>().text = "Buena suerte";


      }


      else if (PlayerPrefs.GetString("Language") == "Fra")
      {

        introText[0].GetComponent<Text>().text = "Le gouvernement a développé une quête spéciale pour former de nouveaux super-soldats.";

        introText[1].GetComponent<Text>().text = "Vous êtes le premier expérimental.";

        introText[2].GetComponent<Text>().text = "Mais rappelez-vous que le gouvernement tuera tous ceux qui ne termineront pas la quête pour éviter de divulguer l'expérience secrète";

        introText[3].GetComponent<Text>().text = "Bonne chance";


      }


      else{
        introText[0].GetComponent<Text>().text="The government has developed a special quest to train new super-soldiers.";

        introText[1].GetComponent<Text>().text="You are the first experimental.";

        introText[2].GetComponent<Text>().text="But remember that Government will kill everyone who won't complete the quest to avoid divulging secret experiment";

        introText[3].GetComponent<Text>().text="Good luck";



      }


    }
}
