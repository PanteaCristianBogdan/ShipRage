# ShipRage
 
Liceul Teoretic “Callatis” Mangalia




“ShipRage”

LUCRARE PENTRU ATESTAREA
COMPETENŢELOR PROFESIONALE





Elev: Pantea Cristian – Bogdan
Clasa: a XII – a B
Profesor coordonator:  Popa Gabriela – Maria


2023 – 2024
 
 

Cuprins



1.	Motivaţia alegerii temei ........................................................ 2
2.	Structura aplicaţiei ................................................................. 3
2.1.	Limbaj de programare – “C#” .......................................... 4
2.2.	Platforma de dezvoltare – “Unity” ................................... 5
3.	Detalii tehnice ......................................................................... 6
4.	Resurse hardware şi software ................................................. 7
4.1.	Hardware ......................................................................... 7
4.2.	Software .......................................................................... 8
5.	Utilizare .................................................................................. 9
6.	Cod sursă .............................................................................. 10
7.	Bibliografie ........................................................................... 12

 
•	Motivaţia alegerii temei

De când am fost mic copil, jocurile video au fost o parte importantă a vieții mele. Acest interes profund pentru jocuri m-a condus către decizia de a explora lumea dezvoltării de jocuri și de a da viață imaginației mele bogate.
În căutarea unei platforme de dezvoltare a jocurilor, am descoperit “Unity” și m-am îndrăgostit instantaneu de versatilitatea și de performanțele pe care le poți atinge. Această platformă folosește limbajul C#, de unde mi-am dat seama că am la dispoziție toate instrumentele necesare pentru a da viață propriilor mele viziuni. Astfel, am început călătoria mea în lumea dezvoltării de jocuri.
În timp ce lucram la "ShipRage", obiectivele mele personale au fost multiple. Pe lângă dorința de a crea un joc distractiv și captivant pentru jucători, am urmărit și să îmi dezvolt abilitățile de programare și să învăț cât mai multe despre procesul de dezvoltare a jocurilor. Acest proiect a fost pentru mine nu doar o oportunitate de a demonstra ceea ce pot face, ci și un mijloc de creștere și dezvoltare personală.
În concluzie, alegerea temei "ShipRage" pentru proiectul meu a fost rezultatul unei pasiuni profunde pentru jocurile video, dorinței de a învăța și de a crește în domeniul dezvoltării de jocuri și aspirației de a crea ceva original și captivant. Acest proiect reprezintă pentru mine mai mult decât un simplu atestat, este o călătorie personală și profesională în lumea fascinantă a jocurilor video.
 
•	Structura aplicaţiei




Pentru dezvoltarea jocului "ShipRage", am optat pentru platforma Unity datorită capacității sale de a oferi un mediu de dezvoltare puternic și versatil. Unity m-a cucerit prin interfața sa intuitivă și setul său complet de instrumente, care m-au ajutat să lucrez eficient și să mă concentrez pe creația unui conținut captivant.
În cadrul proiectului, am utilizat limbajul de programare C# pentru a implementa funcționalitățile jocului. Alegerea limbajului C# a fost motivată de familiaritatea mea cu sintaxa sa clară și puternică, precum și de suportul excelent pe care Unity îl oferă pentru acest limbaj. Folosind C#, am putut să dezvolt și să gestionez logicile jocului într-un mod eficient și organizat.
Pentru editarea codului sursă, am optat pentru utilizarea mediului integrat de dezvoltare (IDE) Visual Studio. Integrarea strânsă dintre Unity și Visual Studio a facilitat procesul de dezvoltare, oferindu-mi un set bogat de instrumente de depanare și funcționalități avansate de editare a codului.
 
–	Limbaj de programare – “C#”




Limbajul C#
1999:  La sfârșitul anilor '90, Microsoft dorea să creeze un limbaj de programare modern și puternic care să rivalizeze cu Java. Anders Hejlsberg și echipa sa au început dezvoltarea limbajului de programare, inițial denumit "C cu Clase", care avea să devină C#.
2000:  C# a fost lansat oficial de către Microsoft ca parte a platformei .NET Framework. A fost proiectat pentru a fi un limbaj orientat pe obiecte, ușor de învățat și puternic, aducând inovații în lumea programării.
Dezvoltare continuă:  De-a lungul anilor, C# a evoluat constant, adăugând noi funcționalități și îmbunătățind performanța. Versiunile ulterioare au adus caracteristici avansate, sintaxă mai elegantă și suport pentru platforme diverse.
Astfel, C# a devenit un limbaj de programare de prim rang, utilizat într-o varietate largă de domenii, de la dezvoltarea de aplicații desktop și web până la jocuri video și aplicații mobile.
 
–	Platforma de dezvoltare – “Unity”



Platforma Unity
2004:  Trei tineri entuziaști din Copenhaga - David, Nicholas și Joachim - au pus bazele Unity Technologies. Împreună au creat un mediu de dezvoltare al jocurilor, numit Unity, pentru Mac OS X.
2005:  Unity 1.0 a fost lansată, oferind dezvoltatorilor de jocuri video un instrument accesibil pentru crearea jocurilor 2D și 3D.
2012:  Lansarea Unity 4 a deschis drumul către dezvoltarea de jocuri pentru iOS și Android, extinzând astfel baza de utilizatori și consolidând poziția Unity ca o platformă multi-platformă.
Astăzi:  Unity este un gigant al dezvoltării de jocuri, folosit de mii de dezvoltatori în întreaga lume pentru a crea experiențe captivante pe o varietate largă de dispozitive și platforme. Din studiouri de jocuri ale amatorilor până la titluri AAA (*Triple A), Unity continuă să fie motorul principal al inovației în industria jocurilor video.
Unity se folosește de clase, unde se declară funcțiile esențiale: “void Start()” care se apelează o dată pe cadru atunci când un script este activat și “void Update()” care se apelează în mod repetat atunci cand un script este activat.



*Triple A (AAA) =  jocuri de înaltă calitate create de studiouri mari, care se remarcă prin grafică impresionantă, poveste captivantă și o logică complexă. 
•	Detalii tehnice


1.	Scripturi și Clase:
•	Proiectul este alcătuit din mai multe scripturi, fiecare având responsabilități specifice.
•	Fiecare script conține clase în care sunt definite funcții și variabile pentru gestionarea diferitelor aspecte ale jocului.
•	De exemplu, scriptul "Ship_Movement.cs" conține logica pentru mișcarea navei jucătorului, convertind input-ul de la tastatură în mișcări sus-jos sau stânga-dreapta ale navei.

2.	Versiunea Editorului Unity:
•	Pentru dezvoltarea proiectului, s-a utilizat versiunea 2021.3.6f1 a editorului Unity.
•	Această versiune a fost aleasă pentru a beneficia de cele mai recente funcționalități, îmbunătățiri și corecții de bug-uri, asigurând un mediu de dezvoltare stabil și optim.

3.	Optimizare și Performanță:
•	S-a acordat o atenție deosebită optimizării și performanței jocului pentru a asigura o experiență de joc fluentă și fără întârzieri.
•	Tehnici de optimizare au fost aplicate pentru a gestiona eficient resursele și pentru a minimiza orice problemă legată de performanță, cum ar fi:
	Optimizarea Codului: Am revizuit și am optimizat codul pentru a elimina buclele inutile, pentru a reduce timpul de procesare și pentru a evita alocările excesive de memorie. 
•	Resurse hardware şi software
–	Hardware

	Procesor
11th Gen Intel(R) Core(TM) i5-11320H sau unul mai performant.
	Placă video
Intel(R) Iris(R) Xe Graphics sau una mai performantă.
	Memorie RAM
16 GB dar se recomandă 32 GB.
	Spațiu de stocare
Fiecare cerință pentru a putea edita proiectul sau pentru a te juca jocul:
	Unity: 5,4 GB spațiu necesar.
	Visual Studio: 1,8 GB spațiu necesar.
	Proiectul propriu zis: 1,5 GB spațiu necesar.
	Jocul după compilare: 100 MB spațiu necesar.

	Unitate CD-ROM

	Afișaj
HD 1920x1080 sau orice monitor cu rezoluție mai ridicată.
	Dispozitive periferice
Orice mouse care are clic stânga si clic dreapta și orice tastatură care are minim 15 taste.
 
–	Software


	Sistem de operare
Microsoft Windows 10 sau un sistem de operare mai recent.
	Program de editat proiectul
Unity, versiunea 2021.3.6f1 de editor.
	Program de editat codul sursă
Visual Studio Code 2022 Community Edition.
	Condiții de testare
Proiectul a fost făcut și testat pe un laptop Gaming Lenovo IdeaPad 3.










 
•	Utilizare


1.	Cum să editezi proiectul cu Unity:
•	Deschide Unity și alege opțiunea "Open Project", apoi selectează folderul “ShipRage - Fișierele codului sursă” pentru a deschide proiectul.
•	Odată deschis proiectul, poți naviga prin fișiere și resurse folosind fereastra "Project". Pentru a adăuga, edita sau șterge obiecte și componente, utilizează ferestrele "Hierarchy" și "Inspector".
2.	Cum să editezi scripturile:
•	Găsește scripturile pe care dorești să le editezi în fereastra "Project" în folderul “Scripts” și deschide-le în Visual Studio.
•	Modifică codul conform nevoilor tale. Poți adăuga noi funcționalități sau ajusta comportamentul existent.
•	Salvează modificările și revino la Unity pentru a le actualiza. Unity va detecta automat modificările și le va încărca în proiect.
3.	Cum să te joci jocul:
•	Pentru a compila jocul, selectează opțiunea "Build Settings" din meniul "File" și alege platforma dorită. Apoi, apasă butonul "Build" pentru a genera executabilul.
•	După ce executabilul a fost generat, găsește-l în directorul de ieșire specificat în timpul procesului de compilare.
•	Rulează executabilul pentru a începe să te joci jocul pe dispozitivul sau platforma selectată.
•	De asemenea puteți găsi un build al jocului deja creat în folderul “ShipRage - Jocul după compilare” și vă puteți juca folosind executabilul “ShipRage.exe”.
 
•	Cod sursă

Codul sursă se poate găsi în folderul “ShipRage - Fișierele codului sursă”, acolo sunt toate fișierele sursă de unde Unity v-a deschide proiectul pentru editare sau vizualizare de cod sursă.

Câteva scripturi principale ale acestui proiect:
	“Pause_Menu_Scripts.cs” 
 
	“Keybindings_Manager.cs”













	“Rocket_Script.cs”







                                                                                                     
 
•	Bibliografie





Pentru realizarea proiectului au fost folosite următoarele link-uri:

	Documentația Unity: https://docs.unity3d.com/ScriptReference/

	Documentația Unity: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/

	Magazinul Unity Asset:                 https://assetstore.unity.com/
