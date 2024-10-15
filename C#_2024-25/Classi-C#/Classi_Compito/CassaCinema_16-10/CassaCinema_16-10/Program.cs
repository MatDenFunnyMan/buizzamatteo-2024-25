using CassaCinema_16_10;

CassaCinema cassa1 = new CassaCinema(100, 10);

cassa1.vendiBiglietti(8);
cassa1.ricarica(2);
cassa1.stampaVendite();

CassaCinema cassaDuplic = new CassaCinema(cassa1);

cassaDuplic.vendiBiglietti(12);
cassaDuplic.ricarica(1);
cassaDuplic.stampaVendite();
