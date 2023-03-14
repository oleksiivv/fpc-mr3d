using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class languageManagement : MonoBehaviour
{



    public int scene=0;
    
    public Text[] arrA;

    public void UpdateLng(){
        if (scene == 0)
        {
            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "You should read this)";
                arrA[1].GetComponent<Text>().text = "Village escape";
                arrA[2].GetComponent<Text>().text = "Maze runner";
                arrA[3].GetComponent<Text>().text = "Rescue time: ";
                arrA[4].GetComponent<Text>().text = "hours.";
                arrA[5].GetComponent<Text>().text = "LOADING...";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "Вам слід прочитати це)";
                arrA[1].GetComponent<Text>().text = "Втеча з селища";
                arrA[2].GetComponent<Text>().text = "Марафон лабіринтом";
                arrA[3].GetComponent<Text>().text = "Час втечі: ";
                arrA[4].GetComponent<Text>().text = "годин.";
                arrA[5].GetComponent<Text>().text = "ЗАВАНТАЖЕННЯ...";

            }



            else if (PlayerPrefs.GetString("Language") == "Esp")
            {
                arrA[0].GetComponent<Text>().text = "Deberías leer estol)";
                arrA[1].GetComponent<Text>().text = "Escape del pueblo";
                arrA[2].GetComponent<Text>().text = "Coureur de labyrinthe";
                arrA[3].GetComponent<Text>().text = "Tiempo de rescate: ";
                arrA[4].GetComponent<Text>().text = "horas.";
                arrA[5].GetComponent<Text>().text = "CARGANDO...";


            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "Vous devriez lire ceci)";
                arrA[1].GetComponent<Text>().text = "Évasion du village";
                arrA[2].GetComponent<Text>().text = "Coureur du labyrinthe";
                arrA[3].GetComponent<Text>().text = "Temps de sauvetage: ";
                arrA[4].GetComponent<Text>().text = "heures.";
                arrA[5].GetComponent<Text>().text = "CHARGEMENT...";
            }
        }

        else if (scene == 1)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "You have escaped the maze!";
                arrA[1].GetComponent<Text>().text = "But you aren't free yet...";
                arrA[2].GetComponent<Text>().text = "The adventure will continue in 'Maze Runner: Big Bang'";
                arrA[3].GetComponent<Text>().text = "Coming soon...";
                //arrA[4].GetComponent<Text>().text = "Thank you and see you later. ";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA [0] .GetComponent <Text> () .text = "Ви втекли з лабіринту!";
                arrA [1] .GetComponent <Text> () .text = "Але це ще не кінець";
                arrA [2] .GetComponent <Text> () .text = "Пригода продовжиться в'Марафон лабіринтом: Великий вибух'";
                arrA [3] .GetComponent <Text> () .text = "Незабаром ...";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                
                arrA [0] .GetComponent <Text> () .text = "¡Has escapado del laberinto!";
                arrA [1] .GetComponent <Text> () .text = "Pero aún no eres libre ...";
                arrA [2] .GetComponent <Text> () .text = "La aventura continuará en 'Maze Runner: Big Bang'";
                arrA [3] .GetComponent <Text> () .text = "Próximamente ...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA [0] .GetComponent <Text> () .text = "Vous avez échappé au labyrinthe!";
                arrA [1] .GetComponent <Text> () .text = "Mais vous n'êtes pas encore libre ...";
                arrA [2] .GetComponent <Text> () .text = "L'aventure continuera dans 'Maze Runner: Big Bang'";
                arrA [3] .GetComponent <Text> () .text = "Bientôt disponible ...";
            }
            else{
                arrA[0].GetComponent<Text>().text = "You have escaped the maze!";
                arrA[1].GetComponent<Text>().text = "But you aren't free yet...";
                arrA[2].GetComponent<Text>().text = "The adventure will continue in 'Maze Runner: Big Bang'";
                arrA[3].GetComponent<Text>().text = "Coming soon...";
            }

        }

        else if (scene == 2)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "You are killed!";
                arrA[1].GetComponent<Text>().text = "Hours: ";
                //arrA[2].GetComponent<Text>().text = "1.Find house\n2.Find place where are weapoon\n3.Go to maze";
                arrA[2].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                arrA[5].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                
                arrA[3].GetComponent<Text>().text = "LOADING...";
                arrA[4].GetComponent<Text>().text = "";
                arrA[6].GetComponent<Text>().text = "save";

                arrA[7].GetComponent<Text>().text = "You need to raise your health!";

                

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "Тебе вбили!";
                arrA[1].GetComponent<Text>().text = "Години: ";
                arrA[2].GetComponent<Text>().text = "Вам слід знайти будинок. Спробуйте також знайти зброю. Лабіринт може бути дуже небезпечним і страшним. Вам слід використати всі можливі ресурси, щоб вижити. Зберіть гроші і відвідайте магазин. Там може бути щось корисне.";
                arrA[5].GetComponent<Text>().text = "Вам слід знайти будинок. Спробуйте також знайти зброю. Лабіринт може бути дуже небезпечним і страшним. Вам слід використати всі можливі ресурси, щоб вижити. Зберіть гроші і відвідайте магазин. Там може бути щось корисне.";
                
                arrA[3].GetComponent<Text>().text = "ЗАВАНТАЖЕННЯ...";
                arrA[4].GetComponent<Text>().text = "";
                arrA[6].GetComponent<Text>().text = "зберегти";
                arrA [7] .GetComponent <Text> () .text = "Вам потрібно відновити здоров'я!";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "Te matan!";
                arrA[1].GetComponent<Text>().text = "Horas: ";
                
                arrA[2].GetComponent<Text>().text = "Deberías encontrar una casa. Intenta encontrar un arma también. El laberinto puede ser muy peligroso y aterrador. Deberías usar todos los recursos posibles para sobrevivir. Recoge dinero y visita la tienda. Puede haber algo útil";
                arrA[5].GetComponent<Text>().text = "Deberías encontrar una casa. Intenta encontrar un arma también. El laberinto puede ser muy peligroso y aterrador. Deberías usar todos los recursos posibles para sobrevivir. Recoge dinero y visita la tienda. Puede haber algo útil";
                
                
                arrA[3].GetComponent<Text>().text = "CARGANDO...";
                arrA[4].GetComponent<Text>().text = "";

                arrA[6].GetComponent<Text>().text = "guardar";
                arrA[7].GetComponent <Text> () .text = "¡Necesitas mejorar tu salud!";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "Tu es tué!";
                arrA[1].GetComponent<Text>().text = "Heures: ";
                
                arrA[2].GetComponent<Text>().text = "Vous devriez trouver une maison. Essayez aussi de trouver une arme. Le labyrinthe peut être très dangereux et effrayant. Vous devez utiliser toutes les ressources possibles pour survivre. Collectez de l'argent et visitez le magasin. Il peut y avoir quelque chose d'utile";
                arrA[5].GetComponent<Text>().text = "Vous devriez trouver une maison. Essayez aussi de trouver une arme. Le labyrinthe peut être très dangereux et effrayant. Vous devez utiliser toutes les ressources possibles pour survivre. Collectez de l'argent et visitez le magasin. Il peut y avoir quelque chose d'utile";
                
                
                arrA[3].GetComponent<Text>().text = "CHARGEMENT...";
                arrA[4].GetComponent<Text>().text = "";

                arrA[6].GetComponent<Text>().text = "enregistrer";

                
                arrA [7] .GetComponent <Text> () .text = "Vous devez augmenter votre santé!";
            }
            else{

                arrA[0].GetComponent<Text>().text = "You are killed!";
                arrA[1].GetComponent<Text>().text = "Hours: ";
                //arrA[2].GetComponent<Text>().text = "1.Find house\n2.Find place where are weapoon\n3.Go to maze";
                arrA[2].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                arrA[5].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                
                arrA[3].GetComponent<Text>().text = "LOADING...";
                arrA[4].GetComponent<Text>().text = "";
                arrA[6].GetComponent<Text>().text = "save";
                arrA[7].GetComponent<Text>().text = "You need to raise your health!";

            }

        }
        else if (scene == 3)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {

                arrA[0].GetComponent<Text>().text = "LOADING...";
                arrA[1].GetComponent<Text>().text = "Now you have a map of the maze. Also there are new feature in the menu, which may help you in your adventure";
                arrA[2].GetComponent<Text>().text = "Leave home";
            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "ЗАВАНТАЖЕННЯ...";
                arrA[1].GetComponent<Text>().text = "Тепер у вас є карта лабіринту. Також в меню є нова функція, яка може допомогти вам у вашій пригоді";
                arrA[2].GetComponent<Text>().text = "Вийти назовні";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {
                arrA[0].GetComponent<Text>().text = "CARGANDO...";
                arrA[1].GetComponent<Text>().text = "Ahora tienes un mapa del laberinto. También hay una nueva función en el menú, que puede ayudarte en tu aventura";
                arrA[2].GetComponent<Text>().text = "Salir de casa";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "CHARGEMENT...";

                arrA[1].GetComponent<Text>().text = "Vous avez maintenant une carte du labyrinthe. Il y a aussi une nouvelle fonctionnalité dans le menu, qui peut vous aider dans votre aventure";
                arrA[2].GetComponent<Text>().text = "Quitter la maison";

            }

        }
        else if (scene == 4)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {


                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Reset progress";
                arrA[2].GetComponent<Text>().text = "yes";
                arrA[3].GetComponent<Text>().text = "no";

                arrA[4].GetComponent<Text>().text = "LOADING...";


            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Очистити прогрес";
                arrA[2].GetComponent<Text>().text = "так";
                arrA[3].GetComponent<Text>().text = "ні";

                arrA[4].GetComponent<Text>().text = "Завантаження...";
            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Restablecer progreso";
                arrA[2].GetComponent<Text>().text = "si";
                arrA[3].GetComponent<Text>().text = "no";

                arrA[8].GetComponent<Text>().text = "CARGANDO...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {

                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Réinitialiser la progression";
                arrA[2].GetComponent<Text>().text = "oui";
                arrA[3].GetComponent<Text>().text = "non";

                arrA[8].GetComponent<Text>().text = "CHARGEMENT...";
            }

        }
        else if (scene == 5)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "Armor can save you from spiders";
                arrA[1].GetComponent<Text>().text = "The maze is closed at night";
                arrA[2].GetComponent<Text>().text = "Be careful at the maze at night. Spiders aren't very friendly";
                arrA[3].GetComponent<Text>().text = "There are a lot of money in the village";
                arrA[4].GetComponent<Text>().text = "Time is relative thing!";
                arrA[5].GetComponent<Text>().text = "Try to move ON the walls in the maze";
                arrA[6].GetComponent<Text>().text = "There is a place where you can find a gun ";

                arrA[8].GetComponent<Text>().text = "LOADING...";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {

                arrA[0].GetComponent<Text>().text = "Броня може захистити тебе від павуків";
                arrA[1].GetComponent<Text>().text = "Лабіринт закритий вночі";
                arrA[2].GetComponent<Text>().text = "Будьте обережні вночі в лабіринті. Павуки не дуже дружні";
                arrA[3].GetComponent<Text>().text = "У селищі безліч грошей";
                arrA[4].GetComponent<Text>().text = "Час - річ відносна!";
                arrA[5].GetComponent<Text>().text = "Спробуйте переміщатися НА стінах в лабіринті";
                arrA[6].GetComponent<Text>().text = "Є місце, де можна знайти бластер";

                arrA[8].GetComponent<Text>().text = "Завантаження...";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "La armadura puede salvarte de las arañas";
                arrA[1].GetComponent<Text>().text = "El laberinto está cerrado por la noche";
                arrA[2].GetComponent<Text>().text = "Tenga cuidado en el laberinto por la noche. Hay criaturas que no son muy amigables";
                arrA[3].GetComponent<Text>().text = "Hay mucho dinero en el pueblo";
                arrA[4].GetComponent<Text>().text = "¡El tiempo es una cosa relativa!";
                arrA[5].GetComponent<Text>().text = "Intenta moverte EN las paredes del laberinto";
                arrA[6].GetComponent<Text>().text = "Hay un lugar donde puedes encontrar un arma";

                arrA[8].GetComponent<Text>().text = "CARGANDO...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "L'armure peut vous sauver des araignées";
                arrA[1].GetComponent<Text>().text = "Le labyrinthe est fermé la nuit";
                arrA[2].GetComponent<Text>().text = "Soyez prudent dans le labyrinthe la nuit. Il y a des créatures qui ne sont pas très amicales";
                arrA[3].GetComponent<Text>().text = "Il y a beaucoup d'argent dans le village";
                arrA[4].GetComponent<Text>().text = "Le temps est une chose relative!";
                arrA[5].GetComponent<Text>().text = "Essayez de vous déplacer SUR les murs du labyrinthe";
                arrA[6].GetComponent<Text>().text = "Il y a un endroit où vous pouvez trouver une arme";

                arrA[8].GetComponent<Text>().text = "CHARGEMENT...";
            }

        }




        else if (scene == 6)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "barrels(health +10%)";
                arrA[1].GetComponent<Text>().text = "map";
                arrA[2].GetComponent<Text>().text = "food(health +15%)";
                arrA[3].GetComponent<Text>().text = "Armor(20% defend)";
                arrA[4].GetComponent<Text>().text = "Armor(40% defend)";
                arrA[5].GetComponent<Text>().text = "Armor(60% defend)";
                arrA[6].GetComponent<Text>().text = "Shop";

                arrA[8].GetComponent<Text>().text = "LOADING...";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {

                arrA[0].GetComponent<Text>().text = "бочки (здоров'я + 10%)";
                arrA[1].GetComponent<Text>().text = "мапа";
                arrA[2].GetComponent<Text>().text = "їжа(здоров'я + 15%)";
                arrA[3].GetComponent<Text>().text = "Броня(20% захисту)";
                arrA[4].GetComponent<Text>().text = "Броня(40% захисту)";
                arrA[5].GetComponent<Text>().text = "Броня(60% захисту)";
                arrA[6].GetComponent<Text>().text = "Крамниця";

                arrA[7].GetComponent<Text>().text = "Завантаження...";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "barriles (salud + 10%)";
                arrA[1].GetComponent<Text>().text = "mapa";
                arrA[2].GetComponent<Text>().text = "comida(salud + 15%)";
                arrA[3].GetComponent<Text>().text = "Armadura(20% de defensa)";
                arrA[4].GetComponent<Text>().text = "Armadura(40% de defensa)";
                arrA[5].GetComponent<Text>().text = "Armadura(60% de defensa)";
                arrA[6].GetComponent<Text>().text = "Tienda";

                arrA[7].GetComponent<Text>().text = "CARGANDO...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "barils (santé + 10%)";
                arrA[1].GetComponent<Text>().text = "carte";
                arrA[2].GetComponent<Text>().text = "nourriture(santé + 15%)";
                arrA[3].GetComponent<Text>().text = "Armure(20% de défense)";
                arrA[4].GetComponent<Text>().text = "Armure(40% de défense)";
                arrA[5].GetComponent<Text>().text = "Armure(60% de défense)";
                arrA[6].GetComponent<Text>().text = "Magasin";

                arrA[7].GetComponent<Text>().text = "CHARGEMENT...";
            }

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        if (scene == 0)
        {
            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "You should read this)";
                arrA[1].GetComponent<Text>().text = "Village escape";
                arrA[2].GetComponent<Text>().text = "Maze runner";
                arrA[3].GetComponent<Text>().text = "Rescue time: ";
                arrA[4].GetComponent<Text>().text = "hours.";
                arrA[5].GetComponent<Text>().text = "LOADING...";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "Вам слід прочитати це)";
                arrA[1].GetComponent<Text>().text = "Втеча з селища";
                arrA[2].GetComponent<Text>().text = "Марафон лабіринтом";
                arrA[3].GetComponent<Text>().text = "Час втечі: ";
                arrA[4].GetComponent<Text>().text = "годин.";
                arrA[5].GetComponent<Text>().text = "ЗАВАНТАЖЕННЯ...";

            }



            else if (PlayerPrefs.GetString("Language") == "Esp")
            {
                arrA[0].GetComponent<Text>().text = "Deberías leer estol)";
                arrA[1].GetComponent<Text>().text = "Escape del pueblo";
                arrA[2].GetComponent<Text>().text = "Coureur de labyrinthe";
                arrA[3].GetComponent<Text>().text = "Tiempo de rescate: ";
                arrA[4].GetComponent<Text>().text = "horas.";
                arrA[5].GetComponent<Text>().text = "CARGANDO...";


            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "Vous devriez lire ceci)";
                arrA[1].GetComponent<Text>().text = "Évasion du village";
                arrA[2].GetComponent<Text>().text = "Coureur du labyrinthe";
                arrA[3].GetComponent<Text>().text = "Temps de sauvetage: ";
                arrA[4].GetComponent<Text>().text = "heures.";
                arrA[5].GetComponent<Text>().text = "CHARGEMENT...";
            }
        }

        else if (scene == 1)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "You have escaped the maze!";
                arrA[1].GetComponent<Text>().text = "But you aren't free yet...";
                arrA[2].GetComponent<Text>().text = "The adventure will continue in 'Maze Runner: Big Bang'";
                arrA[3].GetComponent<Text>().text = "Coming soon...";
                //arrA[4].GetComponent<Text>().text = "Thank you and see you later. ";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA [0] .GetComponent <Text> () .text = "Ви втекли з лабіринту!";
                arrA [1] .GetComponent <Text> () .text = "Але це ще не кінець";
                arrA [2] .GetComponent <Text> () .text = "Пригода продовжиться в \n'Марафон лабіринтом: Великий вибух'";
                arrA [3] .GetComponent <Text> () .text = "Незабаром ...";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                
                arrA [0] .GetComponent <Text> () .text = "¡Has escapado del laberinto!";
                arrA [1] .GetComponent <Text> () .text = "Pero aún no eres libre ...";
                arrA [2] .GetComponent <Text> () .text = "La aventura continuará en 'Maze Runner: Big Bang'";
                arrA [3] .GetComponent <Text> () .text = "Próximamente ...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA [0] .GetComponent <Text> () .text = "Vous avez échappé au labyrinthe!";
                arrA [1] .GetComponent <Text> () .text = "Mais vous n'êtes pas encore libre ...";
                arrA [2] .GetComponent <Text> () .text = "L'aventure continuera dans 'Maze Runner: Big Bang'";
                arrA [3] .GetComponent <Text> () .text = "Bientôt disponible ...";
            }
            else{
                arrA[0].GetComponent<Text>().text = "You have escaped the maze!";
                arrA[1].GetComponent<Text>().text = "But you aren't free yet...";
                arrA[2].GetComponent<Text>().text = "The adventure will continue in 'Maze Runner: Big Bang'";
                arrA[3].GetComponent<Text>().text = "Coming soon...";
            }

        }

        else if (scene == 2)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "You are killed!";
                arrA[1].GetComponent<Text>().text = "Hours: ";
                //arrA[2].GetComponent<Text>().text = "1.Find house\n2.Find place where are weapoon\n3.Go to maze";
                arrA[2].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                arrA[5].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                
                arrA[3].GetComponent<Text>().text = "LOADING...";
                arrA[4].GetComponent<Text>().text = "";
                arrA[6].GetComponent<Text>().text = "save";

                arrA[7].GetComponent<Text>().text = "You need to raise your health!";

                

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "Тебе вбили!";
                arrA[1].GetComponent<Text>().text = "Години: ";
                arrA[2].GetComponent<Text>().text = "Вам слід знайти будинок. Спробуйте також знайти зброю. Лабіринт може бути дуже небезпечним і страшним. Вам слід використати всі можливі ресурси, щоб вижити. Зберіть гроші і відвідайте магазин. Там може бути щось корисне.";
                arrA[5].GetComponent<Text>().text = "Вам слід знайти будинок. Спробуйте також знайти зброю. Лабіринт може бути дуже небезпечним і страшним. Вам слід використати всі можливі ресурси, щоб вижити. Зберіть гроші і відвідайте магазин. Там може бути щось корисне.";
                
                arrA[3].GetComponent<Text>().text = "ЗАВАНТАЖЕННЯ...";
                arrA[4].GetComponent<Text>().text = "";
                arrA[6].GetComponent<Text>().text = "зберегти";
                arrA [7] .GetComponent <Text> () .text = "Вам потрібно відновити здоров'я!";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "Te matan!";
                arrA[1].GetComponent<Text>().text = "Horas: ";
                
                arrA[2].GetComponent<Text>().text = "Deberías encontrar una casa. Intenta encontrar un arma también. El laberinto puede ser muy peligroso y aterrador. Deberías usar todos los recursos posibles para sobrevivir. Recoge dinero y visita la tienda. Puede haber algo útil";
                arrA[5].GetComponent<Text>().text = "Deberías encontrar una casa. Intenta encontrar un arma también. El laberinto puede ser muy peligroso y aterrador. Deberías usar todos los recursos posibles para sobrevivir. Recoge dinero y visita la tienda. Puede haber algo útil";
                
                
                arrA[3].GetComponent<Text>().text = "CARGANDO...";
                arrA[4].GetComponent<Text>().text = "";

                arrA[6].GetComponent<Text>().text = "guardar";
                arrA[7].GetComponent <Text> () .text = "¡Necesitas mejorar tu salud!";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "Tu es tué!";
                arrA[1].GetComponent<Text>().text = "Heures: ";
                
                arrA[2].GetComponent<Text>().text = "Vous devriez trouver une maison. Essayez aussi de trouver une arme. Le labyrinthe peut être très dangereux et effrayant. Vous devez utiliser toutes les ressources possibles pour survivre. Collectez de l'argent et visitez le magasin. Il peut y avoir quelque chose d'utile";
                arrA[5].GetComponent<Text>().text = "Vous devriez trouver une maison. Essayez aussi de trouver une arme. Le labyrinthe peut être très dangereux et effrayant. Vous devez utiliser toutes les ressources possibles pour survivre. Collectez de l'argent et visitez le magasin. Il peut y avoir quelque chose d'utile";
                
                
                arrA[3].GetComponent<Text>().text = "CHARGEMENT...";
                arrA[4].GetComponent<Text>().text = "";

                arrA[6].GetComponent<Text>().text = "enregistrer";

                
                arrA [7] .GetComponent <Text> () .text = "Vous devez augmenter votre santé!";
            }
            else{

                arrA[0].GetComponent<Text>().text = "You are killed!";
                arrA[1].GetComponent<Text>().text = "Hours: ";
                //arrA[2].GetComponent<Text>().text = "1.Find house\n2.Find place where are weapoon\n3.Go to maze";
                arrA[2].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                arrA[5].GetComponent<Text>().text = "You should find house. Also try to find a weapon. Maze may be very dangerous and scary. You should use all possible resources to survive. Collect money and visit shop. There may be something useful";
                
                arrA[3].GetComponent<Text>().text = "LOADING...";
                arrA[4].GetComponent<Text>().text = "";
                arrA[6].GetComponent<Text>().text = "save";
                arrA[7].GetComponent<Text>().text = "You need to raise your health!";

            }

        }
        else if (scene == 3)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {

                arrA[0].GetComponent<Text>().text = "LOADING...";
                arrA[1].GetComponent<Text>().text = "Now you have a map of the maze. Also there are new feature in the menu, which may help you in your adventure";
                arrA[2].GetComponent<Text>().text = "Leave home";
            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "ЗАВАНТАЖЕННЯ...";
                arrA[1].GetComponent<Text>().text = "Тепер у вас є карта лабіринту. Також в меню є нова функція, яка може допомогти вам у вашій пригоді";
                arrA[2].GetComponent<Text>().text = "Вийти назовні";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {
                arrA[0].GetComponent<Text>().text = "CARGANDO...";
                arrA[1].GetComponent<Text>().text = "Ahora tienes un mapa del laberinto. También hay una nueva función en el menú, que puede ayudarte en tu aventura";
                arrA[2].GetComponent<Text>().text = "Salir de casa";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "CHARGEMENT...";

                arrA[1].GetComponent<Text>().text = "Vous avez maintenant une carte du labyrinthe. Il y a aussi une nouvelle fonctionnalité dans le menu, qui peut vous aider dans votre aventure";
                arrA[2].GetComponent<Text>().text = "Quitter la maison";

            }

        }
        else if (scene == 4)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {


                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Reset progress";
                arrA[2].GetComponent<Text>().text = "yes";
                arrA[3].GetComponent<Text>().text = "no";

                arrA[4].GetComponent<Text>().text = "LOADING...";


            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Очистити прогрес";
                arrA[2].GetComponent<Text>().text = "так";
                arrA[3].GetComponent<Text>().text = "ні";

                arrA[4].GetComponent<Text>().text = "Завантаження...";
            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Restablecer progreso";
                arrA[2].GetComponent<Text>().text = "si";
                arrA[3].GetComponent<Text>().text = "no";

                arrA[8].GetComponent<Text>().text = "CARGANDO...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {

                arrA[0].GetComponent<Text>().text = "Change";
                arrA[1].GetComponent<Text>().text = "Réinitialiser la progression";
                arrA[2].GetComponent<Text>().text = "oui";
                arrA[3].GetComponent<Text>().text = "non";

                arrA[8].GetComponent<Text>().text = "CHARGEMENT...";
            }

        }
        else if (scene == 5)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "Armor can save you from spiders";
                arrA[1].GetComponent<Text>().text = "The maze is closed at night";
                arrA[2].GetComponent<Text>().text = "Be careful at the maze at night. Spiders aren't very friendly";
                arrA[3].GetComponent<Text>().text = "There are a lot of money in the village";
                arrA[4].GetComponent<Text>().text = "Time is relative thing!";
                arrA[5].GetComponent<Text>().text = "Try to move ON the walls in the maze";
                arrA[6].GetComponent<Text>().text = "There is a place where you can find a gun ";

                arrA[8].GetComponent<Text>().text = "LOADING...";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {

                arrA[0].GetComponent<Text>().text = "Броня може захистити тебе від павуків";
                arrA[1].GetComponent<Text>().text = "Лабіринт закритий вночі";
                arrA[2].GetComponent<Text>().text = "Будьте обережні вночі в лабіринті. Павуки не дуже дружні";
                arrA[3].GetComponent<Text>().text = "У селищі безліч грошей";
                arrA[4].GetComponent<Text>().text = "Час - річ відносна!";
                arrA[5].GetComponent<Text>().text = "Спробуйте переміщатися НА стінах в лабіринті";
                arrA[6].GetComponent<Text>().text = "Є місце, де можна знайти бластер";

                arrA[8].GetComponent<Text>().text = "Завантаження...";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "La armadura puede salvarte de las arañas";
                arrA[1].GetComponent<Text>().text = "El laberinto está cerrado por la noche";
                arrA[2].GetComponent<Text>().text = "Tenga cuidado en el laberinto por la noche. Hay criaturas que no son muy amigables";
                arrA[3].GetComponent<Text>().text = "Hay mucho dinero en el pueblo";
                arrA[4].GetComponent<Text>().text = "¡El tiempo es una cosa relativa!";
                arrA[5].GetComponent<Text>().text = "Intenta moverte EN las paredes del laberinto";
                arrA[6].GetComponent<Text>().text = "Hay un lugar donde puedes encontrar un arma";

                arrA[8].GetComponent<Text>().text = "CARGANDO...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "L'armure peut vous sauver des araignées";
                arrA[1].GetComponent<Text>().text = "Le labyrinthe est fermé la nuit";
                arrA[2].GetComponent<Text>().text = "Soyez prudent dans le labyrinthe la nuit. Il y a des créatures qui ne sont pas très amicales";
                arrA[3].GetComponent<Text>().text = "Il y a beaucoup d'argent dans le village";
                arrA[4].GetComponent<Text>().text = "Le temps est une chose relative!";
                arrA[5].GetComponent<Text>().text = "Essayez de vous déplacer SUR les murs du labyrinthe";
                arrA[6].GetComponent<Text>().text = "Il y a un endroit où vous pouvez trouver une arme";

                arrA[8].GetComponent<Text>().text = "CHARGEMENT...";
            }

        }




        else if (scene == 6)
        {

            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "barrels(health +10%)";
                arrA[1].GetComponent<Text>().text = "map";
                arrA[2].GetComponent<Text>().text = "food(health +15%)";
                arrA[3].GetComponent<Text>().text = "Armor(20% defend)";
                arrA[4].GetComponent<Text>().text = "Armor(40% defend)";
                arrA[5].GetComponent<Text>().text = "Armor(60% defend)";
                arrA[6].GetComponent<Text>().text = "Shop";

                arrA[8].GetComponent<Text>().text = "LOADING...";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {

                arrA[0].GetComponent<Text>().text = "бочки (здоров'я + 10%)";
                arrA[1].GetComponent<Text>().text = "мапа";
                arrA[2].GetComponent<Text>().text = "їжа(здоров'я + 15%)";
                arrA[3].GetComponent<Text>().text = "Броня(20% захисту)";
                arrA[4].GetComponent<Text>().text = "Броня(40% захисту)";
                arrA[5].GetComponent<Text>().text = "Броня(60% захисту)";
                arrA[6].GetComponent<Text>().text = "Крамниця";

                arrA[7].GetComponent<Text>().text = "Завантаження...";

            }
            else if (PlayerPrefs.GetString("Language") == "Esp")
            {

                arrA[0].GetComponent<Text>().text = "barriles (salud + 10%)";
                arrA[1].GetComponent<Text>().text = "mapa";
                arrA[2].GetComponent<Text>().text = "comida(salud + 15%)";
                arrA[3].GetComponent<Text>().text = "Armadura(20% de defensa)";
                arrA[4].GetComponent<Text>().text = "Armadura(40% de defensa)";
                arrA[5].GetComponent<Text>().text = "Armadura(60% de defensa)";
                arrA[6].GetComponent<Text>().text = "Tienda";

                arrA[7].GetComponent<Text>().text = "CARGANDO...";

            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "barils (santé + 10%)";
                arrA[1].GetComponent<Text>().text = "carte";
                arrA[2].GetComponent<Text>().text = "nourriture(santé + 15%)";
                arrA[3].GetComponent<Text>().text = "Armure(20% de défense)";
                arrA[4].GetComponent<Text>().text = "Armure(40% de défense)";
                arrA[5].GetComponent<Text>().text = "Armure(60% de défense)";
                arrA[6].GetComponent<Text>().text = "Magasin";

                arrA[7].GetComponent<Text>().text = "CHARGEMENT...";
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (scene == 0)
        {
            if (PlayerPrefs.GetString("Language") == "Eng")
            {
                arrA[0].GetComponent<Text>().text = "You should read this)";
                arrA[1].GetComponent<Text>().text = "Village escape";
                arrA[2].GetComponent<Text>().text = "Maze runner";
                arrA[3].GetComponent<Text>().text = "Rescue time: ";
                arrA[4].GetComponent<Text>().text = "hours.";

            }
            else if (PlayerPrefs.GetString("Language") == "Ukr")
            {
                arrA[0].GetComponent<Text>().text = "Вам слід прочитати це)";
                arrA[1].GetComponent<Text>().text = "Втеча з селища";
                arrA[2].GetComponent<Text>().text = "Марафон лабіринтом";
                arrA[3].GetComponent<Text>().text = "Час втечі: ";
                arrA[4].GetComponent<Text>().text = "годин.";

            }



            else if (PlayerPrefs.GetString("Language") == "Esp")
            {
                arrA[0].GetComponent<Text>().text = "Deberías leer estol)";
                arrA[1].GetComponent<Text>().text = "Escape del pueblo";
                arrA[2].GetComponent<Text>().text = "El corredor del laberinto";
                arrA[3].GetComponent<Text>().text = "Tiempo de rescate: ";
                arrA[4].GetComponent<Text>().text = "horas.";


            }
            else if (PlayerPrefs.GetString("Language") == "Fra")
            {
                arrA[0].GetComponent<Text>().text = "Vous devriez lire ceci)";
                arrA[1].GetComponent<Text>().text = "Évasion du village";
                arrA[2].GetComponent<Text>().text = "le coureur du labyrinthe";
                arrA[3].GetComponent<Text>().text = "Temps de sauvetage: ";
                arrA[4].GetComponent<Text>().text = "heures.";
            }
        }

        // else if (scene == 1)
        // {

        //     if (PlayerPrefs.GetString("Language") == "Eng")
        //     {
        //         arrA[0].GetComponent<Text>().text = "You are wild! Nice job";
        //         arrA[1].GetComponent<Text>().text = "You completed 'Village escape. The maze runner'";
        //         arrA[2].GetComponent<Text>().text = "Your best time is saved and you can try to make it better";
        //         arrA[3].GetComponent<Text>().text = "'Village Escape. Maze runner. Part 2' is developing now and very soon you will be able to try it. ";
        //         arrA[4].GetComponent<Text>().text = "Thank you and see you later. ";

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Ukr")
        //     {
        //         arrA[0].GetComponent<Text>().text = "Ви вільні! Хороша робота";
        //         arrA[1].GetComponent<Text>().text = "Ви завершили гру 'Втеча з селища. Марафон лабіринтом'";
        //         arrA[2].GetComponent<Text>().text = "Ваш рекордний час збережено і тепер ви можете спробувати покращити його";
        //         arrA[3].GetComponent<Text>().text = "Друга частина гри заразу розробці і вже дуже скоро ви зможете спробувати зіграти в неї.";
        //         arrA[4].GetComponent<Text>().text = "До скорої зустрічі.";

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Esp")
        //     {

        //         arrA[0].GetComponent<Text>().text = "¡Usted es salvaje! Buen trabajo";
        //         arrA[1].GetComponent<Text>().text = "Has completado 'Escape del pueblo.El corredor del laberinto'";
        //         arrA[2].GetComponent<Text>().text = "Tu mejor tiempo está guardado y puedes intentar mejorarlo";
        //         arrA[3].GetComponent<Text>().text = "'Village Escape. Maze runner. Part 2' se está desarrollando ahora y muy pronto podrás probarlo.";
        //         arrA[4].GetComponent<Text>().text = "Gracias y hasta luego.";

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Fra")
        //     {
        //         arrA[0].GetComponent<Text>().text = "Tu es sauvage! Bon travail";
        //         arrA[1].GetComponent<Text>().text = "Vous avez terminé 'Village escape. The maze runner'";
        //         arrA[2].GetComponent<Text>().text = "Votre meilleur temps est enregistré et vous pouvez essayer de l'améliorer";
        //         arrA[3].GetComponent<Text>().text = "'Village Escape. Coureur de labyrinthe. La partie 2' se développe maintenant et très bientôt vous pourrez l'essayer.";
        //         arrA[4].GetComponent<Text>().text = "Merci et à plus tard.";
        //     }

        // }

        // else if (scene == 2)
        // {

        //     if (PlayerPrefs.GetString("Language") == "Eng")
        //     {
        //         arrA[0].GetComponent<Text>().text = "You are killed!";
        //         arrA[1].GetComponent<Text>().text = "Hours: ";
        //         arrA[2].GetComponent<Text>().text = "1.Find house\n2.Find place where are blasters\n3.Go to maze";
        //         //arrA[3].GetComponent<Text>().text = "LOADING.";
        //         arrA[4].GetComponent<Text>().text = "";
        //         arrA[5].GetComponent<Text>().text = "saved";

                

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Ukr")
        //     {
        //         arrA[0].GetComponent<Text>().text = "Тебе вбили!";
        //         arrA[1].GetComponent<Text>().text = "Години: ";
        //         arrA[2].GetComponent<Text>().text = "1.Знайди дім\n2.Знайди зброю\n3.Йди в лабіринт";
        //         //arrA[3].GetComponent<Text>().text = "ЗАВАНТАЖЕННЯ.";
        //         arrA[4].GetComponent<Text>().text = "";
        //         arrA[5].GetComponent<Text>().text = "збережено";

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Esp")
        //     {

        //         arrA[0].GetComponent<Text>().text = "Te matan!";
        //         arrA[1].GetComponent<Text>().text = "Horas: ";
        //         arrA[2].GetComponent<Text>().text = "1.Encuentra la casa\n2.Encuentra el lugar donde están los blásters \n3.Ve al laberinto";
        //         //arrA[3].GetComponent<Text>().text = "CARGANDO.";
        //         arrA[4].GetComponent<Text>().text = "";
        //         arrA[5].GetComponent<Text>().text = "salvado";

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Fra")
        //     {
        //         arrA[0].GetComponent<Text>().text = "Tu es tué!";
        //         arrA[1].GetComponent<Text>().text = "Heures: ";
        //         arrA[2].GetComponent<Text>().text = "1.Trouver une maison \n2.Trouver un endroit où se trouvent des blasters \n3.Aller au labyrinthe";
        //         //arrA[3].GetComponent<Text>().text = "CHARGEMENT.";
        //         arrA[4].GetComponent<Text>().text = "";
        //         arrA[5].GetComponent<Text>().text = "enregistré";
        //     }

        // }
        
        // else if (scene == 3)
        // {

        //     if (PlayerPrefs.GetString("Language") == "Eng")
        //     {


        //         arrA[1].GetComponent<Text>().text = "Now you can go to the menu to find something new that will help you complete the game";
        //         arrA[2].GetComponent<Text>().text = "Leave home";
        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Ukr")
        //     {
        //         arrA[1].GetComponent<Text>().text = "А зараз перейди у меню, там ти побачиш дещо, що допоможе тобі пройти гру";
        //         arrA[2].GetComponent<Text>().text = "Вийти назовні";

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Esp")
        //     {

        //         arrA[1].GetComponent<Text>().text = "Ahora puedes ir al menú para encontrar algo nuevo que te ayudará a completar el juego.";
        //         arrA[2].GetComponent<Text>().text = "Salir de casa";

        //     }
        //     else if (PlayerPrefs.GetString("Language") == "Fra")
        //     {

        //         arrA[1].GetComponent<Text>().text = "Maintenant, vous pouvez aller dans le menu pour trouver quelque chose de nouveau qui vous aidera à terminer le jeu";
        //         arrA[2].GetComponent<Text>().text = "Quitter la maison";

        //     }

        // }
    }
}
