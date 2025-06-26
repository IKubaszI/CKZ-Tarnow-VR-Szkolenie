# Materiały do zajęć Unity VR – Konspekty

Witaj! Jeśli nie udało Ci się wykonać całego konspektu podczas zajęć – nic straconego. Każdy etap kursu dostępny jest w osobnym **branchu** tego repozytorium. Możesz wczytać gotowy stan projektu i kontynuować naukę dokładnie tam, gdzie skończyłeś.

---

## Jak korzystać z tego repozytorium?

### 1. Zainstaluj GitHub Desktop (zalecane)
Pobierz aplikację: [https://desktop.github.com](https://desktop.github.com)

### 2. Sklonuj repozytorium
1. Otwórz GitHub Desktop
2. Wybierz `File → Clone repository`
3. Wklej link:  
   `https://github.com/IKubaszI/CKZ-Tarnow-VR-Szkolenie.git`
4. Wybierz lokalizację na dysku
5. Kliknij `Clone`

---

## Branch `main` – materiały bazowe

Branch `main` zawiera plik:

**`Materialy.unitypackage`** – paczka z:
- gotowymi materiałamim
- dźwiękami,
- prefabami,
- niezbędnymi assetami wspólnymi dla całego kursu.

### Jak zaimportować?
1. Otwórz projekt Unity
2. Znajdź plik `Materialy.unitypackage` w Eksploratorze Windows
3. Kliknij go dwukrotnie
4. W otwartym oknie zaznacz wszystko i kliknij `Import`

---

## Pozostałe branche: `konspekt-1`, `konspekt-2`, ..., `konspekt-10`

Każdy branch to gotowa scena i kod po zakończeniu konkretnego etapu kursu. Użyj ich, jeśli:
- nie zdążyłeś czegoś zrobić,
- chcesz porównać z własnym projektem,
- chcesz pracować dalej bez straty czasu.

| Branch         | Temat konspektu                             |
|----------------|----------------------------------------------|
| `konspekt-1`   | Sprzęt, BHP i pierwsze uruchomienie          |
| `konspekt-2`   | Pierwszy projekt – Unity + XR Plugin         |
| `konspekt-3`   | XR Rig – dodanie gracza i kontrolerów        |
| `konspekt-4`   | Interaktywne obiekty: stół, kostka           |
| `konspekt-5`   | Logika gry: punktacja, dźwięki, UI           |
| `konspekt-6`   | UI w VR – przyciski, suwak, handler          |
| `konspekt-7`   | Import assetów + pistolet VR                 |
| `konspekt-8`   | Gra: strzelanie do puszek                    |
| `konspekt-9`   | Ruch gracza: teleport, wspinaczka, skok      |
| `konspekt-10`  | Budowanie gry do .exe                        |

---

## Jak przełączyć się na wybrany konspekt?

1. W GitHub Desktop kliknij listę branchy (lewy górny róg)
2. Wybierz np. `konspekt-5`
3. Kliknij `Fetch origin` i potem `Pull`
4. Otwórz projekt w Unity Hub

---

## Jak uruchomić projekt Unity?

1. W Unity Hub kliknij `Add` i wybierz folder projektu (tam gdzie masz sklonowane repozytorium)
2. Po uruchomieniu projektu przejdź do:
   - `Assets/Scenes/SampleScene.unity`
3. Kliknij przycisk `Play` (górny pasek edytora)
4. Załóż gogle VR i testuj

---

## Podsumowanie wszystkich konspektów

- **Sprzęt, BHP i konfiguracja** – Dowiesz się, jak bezpiecznie korzystać z gogli VR, poprawnie je zakładać i kalibrować.
- **Pierwszy projekt w Unity** – Nauczysz się obsługi edytora Unity i przygotujesz środowisko pod VR.
- **XR Rig** – Dodasz prefab gracza, poznasz jego strukturę i nauczysz się go konfigurować.
- **Interaktywne obiekty** – Zbudujesz stół i kostkę możliwą do chwytania, nauczysz się pracy z fizyką i kolizjami.
- **Logika gry** – Stworzysz system punktacji, UI z wynikiem, spawnery i dźwięki.
- **UI w VR** – Stworzysz panel UI w World Space, obsłużysz suwaki i przyciski z kontrolera.
- **Import assetów i pistolet VR** – Zaimportujesz gotowy model pistoletu i dodasz mechanikę strzelania.
- **Strzelanie do puszek** – Zbudujesz mini grę z przyciskiem resetującym i dźwiękiem trafień.
- **Ruch gracza w VR** – Dodasz teleportację, wspinaczkę i skok. Nauczysz się redukować chorobę lokomocyjną.
- **Budowanie projektu VR** – Wyeksportujesz grę do `.exe`, dodasz własne logo, ikonę i ekran startowy.

---

## W razie problemów

Masz pytanie? Coś nie działa?

📧 **Kontakt:** kubaszary@interia.pl  
Lub zapytaj prowadzącego na zajęciach.

---

