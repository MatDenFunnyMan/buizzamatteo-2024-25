
using Macchina;

Persona a = new Persona("Diego", "Malara", 192, 2014); // Qui viene creato l'oggetto persona e gli alloca memoria (istanza)
// a.nome = "Sergio";
// a.cognome = "Gonzalez";

// a.saluta();
// a.spacca_noci_con_gomito();

/* Caso con tutti public

Console.WriteLine(a.nome);
Console.WriteLine(a.cognome);
Console.WriteLine(a.altezza);
a.eta = 25; // Inconsistenza 2 --> Se cambio età, in questo esempio, cambia l'eta ma non l'anno di nascita (e viceversa se cambia anno di nascita)
Console.WriteLine(a.eta);
Console.WriteLine(a.annoNascita);
*/

// Information Hiding --> Gli attributi devono essere privati/sono consigliati di essere privati

// Caso con Getter e Setter (Properties)

/*
Console.WriteLine(a.nome);
Console.WriteLine(a.cognome);
Console.WriteLine(a.altezza);
Console.WriteLine(a.getEta());
a.setEta(11);
Console.WriteLine(a.annoNascita);
*/

// Inconsinstenza --> se metto a.vivo = true, dovrebbe essere false, ma il programma così lo mette forzato a true

// a.spacca_noci_con_gomito();
// Console.WriteLine(a.vivo);

/*
Persona b = new Persona();
b.nome = "Sergio";
b.cognome = "Gonzalez";

b.saluta();
b.spacca_noci_con_gomito();
*/

