using CentraleElettrica_16_10;

CentraleElettrica centrale = new CentraleElettrica(10);

Utilizzatore utilizzatoreA = new Utilizzatore("A", 6);
Utilizzatore utilizzatoreB = new Utilizzatore("B", 8);
Utilizzatore utilizzatoreC = new Utilizzatore("C", 2);

centrale.collegaUtilizzatore(utilizzatoreA);
centrale.collegaUtilizzatore(utilizzatoreB);
centrale.collegaUtilizzatore(utilizzatoreC);

Console.WriteLine($"Energia in uso: {centrale.GetEnergiaUso()} unità");

CentraleElettrica centraleDuplicata = new CentraleElettrica(centrale);
Console.WriteLine("Centrale duplicata creata. Energia disponibile: " + centraleDuplicata.GetEnergiaDispoibile() + " unità.");