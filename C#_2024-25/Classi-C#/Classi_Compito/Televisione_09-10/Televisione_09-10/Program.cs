using Televisione_09_10;

Televisione tv1 = new Televisione("Samsung", "OLED", true); 
Televisione tv2 = new Televisione("LG", "QLED", 200, 0, 100, true);

/* COMANDI DISPONIBILI
 * 
 * Accendi ( es: tv1.accendi() )
 * Spegni ( es: tv1.spegni() )
 * Alza volume di 1 unità ( es: tv1.alzaVolume() )
 * Abbassa volume di 1 unità tv1.abbassaVolume() )
 * Alza volume di n unità ( es: tv1.alzaVolume(numero) )
 * Abbassa volume di n unità ( es: tv1.abbassaVolume(numero) )
 * Incrementa canale
 * Decrementa canale
 * Verifica se accesa o no
 * Canale corrente
 * Volume corrente
 * 
 */

tv1.stampaInfo();
Console.WriteLine(" ");
tv2.stampaInfo();