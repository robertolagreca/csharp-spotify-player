// See https://aka.ms/new-console-template for more information
//Dobbiamo realizzare un programma che emuli in maniera semplice quanto faccia Spotify, ossia riprodurre della
//musica e dei podcasts!
//CREAZIONE DELL’INTERFACCIA:
//Creiamo un’interfaccia IContenutoRiproducibile che definisce un contratto affinché un contenuto sia
//riproducibile, e che quindi garantisca le seguenti funzionalità:
//•	Play(): metodo che deve permettere di riprodurre un contenuto audio.
//•	Pausa(): metodo che permette di mettere in pausa un contenuto
//•	Stop(): metodo che permette di interrompere la riproduzione dell’audio.
//IMPLEMENTAZIONI DELL’INTERFACCIA:
//Una volta dichiarata la nostra Interfaccia usiamola nelle classi concrete:
//•	Brano
//•	Podcast
//per dichiarare che queste classi implementano le funzionalità di essere riproducibili implementando
//l’interfaccia dichiarata. In queste classi, cercate di implementare questi metodi come meglio credete e in
//maniera non troppo complicata, come ad esempio semplicemente:
//•	Se faccio Play su un brano vorrei che mi venisse scritto in console “Riproduzione del brano Billie Jean
//di Michael Jackson…”
//•	Se metto in pausa un brano mi viene scritto “Messo in pausa il brano Billie Jean di Michael Jackson ”
//•	Se metto in stop un brano mi viene scritto “Messo in stop il brano Billie Jean di Michael Jackson e
//riavvolto all’inizio del brano”
//Esempi simili possono essere applicati per i metodi in un podcast!Nell’implementazione concreta della classe
//Brano e Podcast dichiarate tutti le proprietà/attributi privati, getters, setters, altri metodi più specifichi
//che ritenete opportuni come avete sempre fatto.UTILIZZO DELLE VOSTRE CLASSI E INTERFACCE:
//Una volta creata l’interfaccia, e le classi Brano e Podcast, provate ad usarle nel vostro programma principale
//per istanziare una lista di IContenutoRiproducibile (si lo so potrebbe sembrare strano ma un interfaccia può
//essere usata come tipo in una lista ad esempio per avere un lista astratta di oggetti che so che
//implementeranno quell’interfaccia e su cui ci potrò lavorare senza sapere nel concreto chi saranno poi i miei
//veri oggetti (Brani o Podcast che siano). Questo è proprio il bello dell’astrazione e delle interfacce: mi
//dimentico dei dettagli e voglio solo interagire con Contenuti e astratti che so almeno essere riproducibili!
//Utilizzate questa lista per inserirci dentro qualche Brano e qualche Podcast. Poi provare a riprodurre con Play
//() qualche vostro ContenutoRiproducibile contenuto nella lista come meglio preferite (Se lo ritenete opportuno
//stampate la lista in console e chiedete all'utente quale contenuto vuole riprodurre a partire dal solo titolo
//magari, e mettetelo in Play()) oppure semplicemente provate ad accedere alla vostra lista di contenuti e notate
//come potete fare Play(), Pausa() e Stop() nei vostri contenuti e osservando come poi la risposta che vi viene
//data dipenda dall'oggetto (brano o podcast che sia) concretamente istanziato e che implementa l'interfaccia di
//essere riproducibile.

//BONUS:
//Se riuscite provate eventualmente a fare un “Refactoring” del vostro codice e ad usare l’ereditarietà per
//creare una classe generica ContenutoAudio che implementa l’interfaccia IRiproducibile e poi estendete questa
//classe generica per creare le sottoclassi Brano e Podcast più specifiche con qualche chicca in più che
//deciderete voi a vostro piacimento. Ricordatevi che potete avvalervi anche degli ovverride nelle sottoclassi
//per ridichiarare comportamenti della vostra superclasse ContenutoAudio nelle sottoclassi Brano e Podcast.

using CSharpSpotifyPlayer;

string song, podTitle;

song = "Still D.R.E. di Dr. Dre feat. Snoop Dogg";
podTitle = "Tintoria Podcast";

//Lista di tipo interfaccia in cui metto dentro gli oggetti
List<IContenutoRiproducibile> media = new List<IContenutoRiproducibile>
{
    new Brano(song),
    new Podcast(podTitle)
};

foreach (IContenutoRiproducibile content in media)
{
    Console.WriteLine(content);
    Console.WriteLine($"Contenuto selezionato: {content}");
    content.Play();
    content.Pause();
    content.Stop();
    Console.WriteLine(Environment.NewLine);
}

