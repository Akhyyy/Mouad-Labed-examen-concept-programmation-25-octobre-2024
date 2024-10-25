*Par Mouad Labed*

**Turbo Rivals est un jeu de course dynamique où les joueurs affrontent des adversaires contrôlés par l'intelligence artificielle (IA) sur différents circuits. Les courses sont enrichies par un système d'objets spéciaux qui peuvent être utilisés stratégiquement pendant la course.**

# 1.	Système de course 
o	Il peut y avoir un maximum de 10 véhicules par course (1 joueur + 9 IA)
o	Le jeu peut être jouée en vue de dessus (top-down) ou arrière
o	La physique de jeu est de type arcade. 
o	Les véhicules peuvent entrer en collision mais sans risque pour les joueurs. 
o	Ils peuvent aussi frapper les clôtures du circuit, ce qui va les ralentir mais pas les détruire. 
o	Les joueurs peuvent accélérer et ralentir sur le circuit. Puis orienter le véhicule de droite à gauche. 
o	Chaque véhicule possède 3 boosts de vitesse au départ. 

# 2.	Objets spéciaux 
o	Boost de Vitesse sur 6 secondes qui augmente la vitesse
o	Bouclier défensif pour se protéger contre les attaques
o	Missile guide qui peut atteindre un véhicule vers l’avant
o	Tache d'huile qui peut faire ralentir les véhicules qui roulent sur celle-ci
o	EMP (onde de choc) qui peut stopper tous les véhicules en avant sauf ceux qui ont un bouclier. 

# 3.	Intelligence Artificielle 
o	Ce sont les principaux ennemis dans le jeu. Ils naviguent sur le circuit en utilisant un algorithme de jeu pour trouver le chemin le plus court. 
o	Ils peuvent éviter les obstacles comme la tache d’huile. 
o	Ils utilisent les objets spéciaux de façon stratégique en fonction de leur position dans la course.

# 4.	Interface et menus 
o	Sélection de circuit
o	Tableau des scores
o	Interface en course (position, mini-carte, numéro du tour, vitesse, objets spéciaux disponibles)

## Hiérarchie des Classes

### Hiérarchie de classe proposée

| Classe principale | Sous-classes ou éléments associés               | Description |
|-------------------|-------------------------------------------------|-------------|
| **GameManager**   | -                                               | Contrôle principal du jeu : initialise la course, gère les états de jeu et la progression. |
| **Vehicule**      | - PlayerVehicle<br>- AIVehicle                  | Classe de base pour tous les véhicules. Définit les propriétés générales comme la vitesse, les collisions, etc. |
| **PlayerVehicule**| -                                               | Hérite de `Vehicule`. Ajoute des contrôles spécifiques au joueur, comme l’accélération et le freinage manuels. |
| **AIVehicule**    | - AIController                                  | Hérite de `Vehicule`. Utilise un contrôleur d’IA pour naviguer sur le circuit et utiliser des objets spéciaux stratégiquement. |
| **Item**          | - SpeedBoost<br>- Shield<br>- Missile<br>- OilSlick<br>- EMP | Classe de base pour tous les objets spéciaux du jeu. Chacun d’eux a des effets spécifiques pour modifier la vitesse ou affecter les autres véhicules. |
| **Track**         | - Obstacle<br>- Boundary                        | Définit le circuit, y compris les obstacles et les limites. Les obstacles sont utilisés pour ralentir les véhicules en cas de collision. |
| **UIManager**     | -                                               | Gère l’interface utilisateur, affichant la position, la mini-carte, les objets disponibles, et d'autres. |
| **Leaderboard**   | -                                               | affiche le classement des joueurs en fonction de leur position soit du 1er jusqu'a dernier 10e. |
| **AIController**  | -                                               | Gère le comportement et les décisions des véhicules contrôlés par l’IA pour éviter les obstacles. |

Cloner le dépôt :
```bash
git clone https://github.com/username/TurboRivals.git

