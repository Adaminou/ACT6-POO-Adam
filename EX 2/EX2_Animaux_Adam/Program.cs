
using EX2_Animaux_Adam;

Animal[] mesAnimaux = new Animal[5];

mesAnimaux[0] = new Chat("Yuji","12/10/2020",25,false,02);
mesAnimaux[1] = new Chien("Yuki","23/03/2020",40,true,016);
mesAnimaux[2] = new Lapin(6,"Yuri","16/02/2020",30,false,200537);


for (int i = 0; i < mesAnimaux.Length; i++)
{
    Console.WriteLine(mesAnimaux[i].Affiche());
    Console.WriteLine(mesAnimaux[i].Nom + mesAnimaux[i].Manger());

    if (mesAnimaux[i] is Chat chat)
    {
        Console.WriteLine(chat.Miaule());
    }

    else if (mesAnimaux[i] is Chien chien)
    {
        Console.WriteLine(chien.Aboyer());
    }

    else if (mesAnimaux[i] is Lapin lapin)
    {
        Console.WriteLine(lapin.Bondir());
    }
}