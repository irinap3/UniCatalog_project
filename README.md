# UniCatalog Project

## Descriere
UniCatalog este un proiect care are ca scop gestionarea și catalogarea informațiilor universitare. Acesta permite utilizatorilor să adauge, să modifice și să vizualizeze date referitoare la
cursuri, profesori și studenți.
- Pe baza unui formular de Login, utilizatorul poate alege in ce calitate navigheaza pe aplicatie: student, profesor, admin. Daca utilizatorul greseste parola/ e-mail , ii va aparea un mesaj
de eroare. Altfel, daca acesta nu este inscris in cadrul facultatii, acest lucru ii va fi de asemenea adus la cunostinta. 
- Daca logarea a avut succes, iar utilizatorul este student, acesta va acea acces la urmatoarele: detalii personale, note, taxe.
- Daca utilizatorul este profesor, acesta va avea acces la : detalii profesor, vizualizare cursuri in functie de specializare, adaugare/modificare/stergere note.
- Daca utilizatorul este admin, acesta are posibilitatea de a genera conturi de student/profesor in baza carorara ceilalti utilizatori se pot autentifica. In plus, aplicatia dorea ca in 
sectiunea "Formeaza grupe" sa preia un fisier Excel si sa genereze fiecarui elev codificarea grupei. 

## Caracteristici
- Adăugarea de noi cursuri și profesori
- Vizualizarea informațiilor despre studenți
- Actualizarea și ștergerea datelor existente

## Cerințe
- Sistem de operare: Windows/Linux/macOS
- .NET Framework 4.7+
- Microsoft SQL Server

## Instalare
Instrucțiuni pentru instalarea și configurarea proiectului:
1. Clonează repository-ul: `git clone https://github.com/irinap3/UniCatalog_project.git`
2. Navighează în directorul proiectului: `cd UniCatalog_project`
3. Deschide soluția în Visual Studio: `UniCatalog.sln`
4. Configurează conexiunea la baza de date în fișierul `appsettings.json`.

## Utilizare
Instrucțiuni pentru rularea aplicației:
1. Compilează și rulează soluția în Visual Studio.
2. Accesează interfața aplicației prin browser-ul tău la adresa `http://localhost:5000`.

## Contribuții
Instrucțiuni pentru cei care doresc să contribuie:
1. Forkează repository-ul
2. Creează o ramură nouă: `git checkout -b nume-ramura`
3. Fă modificările dorite și comite-le: `git commit -m 'Mesaj commit'`
4. Trimite un pull request

## Autori
- Irina P - [contact](mailto:irinap@example.com)

## Mulțumiri
Mulțumiri speciale tuturor celor care au contribuit la dezvoltarea acestui proiect.
- Stan Stefania Larisa
- Stan Denisa Ioana
- Ciovana Adriana
