# Sustav za upravljanje količinom namirnica u ugostiteljstvu


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Matej Ritoša | mritosa20@student.foi.hr | 0016150816 | mritosa
Nikola Parag | nparag20@student.foi.hr | 0035217959 | nparag20
Lovro Pejaković | lpejakovi20@student.foi.hr | 0016150223 | lpejakovi20

## Opis domene
U ugostiteljstvu dolazi do problema organizacije narmirnica. Glavni kuhari često moraju voditi računa o količini namirnica na skladištu i ponekad im je teško procjeniti koliko namirnica troše i koju količinu namirnica trebaju naručiti. Zbog toga dolazi do bacanja hrane zbog prevelikih narudžba ili nedostatka namirnica za kuhanje jela. Zbog tih problema odlučili smo ugostiteljima olakšati proces nabave i upravljanja količinom namirnica.
## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka koju ćemo za vas mi pripremiti i dati vam pristup naknadno. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Pristup ovom softveru će imati računovodstvo ugostiteljskih objekata i osobe nadležne za upravljanjem količinama namirnica u kuhinji(glavni kuhar/ica, slastičar, mesar). Njima će biti podjeljene uloge,  te ovisno o tome imat će pristup različitim funkcionalnostima u aplikaciji. Svima će biti omogućen pregled namirnica, a osobama nadležnim za naručivanje namirnica biti omogućena izrada narudženice koja će biti proslijeđena računovodstvu. Naša će aplikacija omogućiti korisnicima omogućiti bilježenje dnevnih potrošenih namirnica. Računovodstvu će biti omogućen pregled svih narudžbenica te izrada izvještaja o novčanoj potrošnji, količini iskorištenih i ukupnoj količini namirnica.

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristup sustavu potrebna je autentikacija korisnika pomoću login funkcionalnosti. Korisnik bira ulogu te sa svojim podacima koji su mu dodijeljenji prilikom registracije dobiva pristup sustavu. | Matej Ritoša
F02 | Registration | Prije nego što se korisnik može prijaviti potrebno je kreirati korisnički račun. | Lovro Pejaković
F03 | Pregled namirnica | Korisnicima će biti omogućen pregled trenutne količine namirnica na skladištu. | Nikola Parag
F04 | Kreiranje narudžbenice | Korisnicima će biti omogućeno dodavanje, brisanje, i izmjena količine namirnica u narudžbenici. | Nikola Parag
F05 | Unos potrošenih namirnica | Korisnicima će biti omogućen unos dnevnih potrošenih namirnica. Ostali će korisnici će automatski moći vidjeti promjene broja  namirnica. | Lovro Pejaković
F06 | Pregled narudžbenica | Korisnici koji će biti prijavljeni s ulogom računovodstva će imati mogućnost pregleda svih narudžbenica. | Matej Ritoša
F07 | Generiranje izvještaja potrošenih namirnica. | Korisnici koji će biti prijavljeni s ulogom računovodstva imati mogućnost generiranja izvještaja koji će sadržavati popis količine potrošene hrane. | Nikola Parag
F08 | Generiranje izvještaja o troškovima | Korisnici koji će biti prijavljeni s ulogom računovodstva imati mogućnost generiranja izvještaja koji će sadržavati popis svih troškova namirnica. | Lovro Pejaković
F09 | Statistika iskorištenosti namirnica  | Sustav će računovodstvu omogućiti kreirati statistički izvještaj o iskorištenosti namirnica tokom svakog mjeseca u tekućoj godini. | Matej Ritoša

## Tehnologije i oprema
Visual studio Code 2022, Visual Paradigm, Figma, Github...
