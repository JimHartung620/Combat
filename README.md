# Combat
Combat is my first attempt at making a simple, turn-based RPG game.  My primary focus was on determining how to structure the code and class hierarchy.  As such, the 3 character classes are relatively generic and the attack and stat indexes are extremely simple.  As I continue to develop the game, I will look more into game balancing, adding more depth to the attack and stat systems, and adding some uniqueness to the title.

# Game Structure
Combat is designed as a two person game where each player selects a combatant to battle with.  It is a turn based game that allows each player to select 1 attack per turn.  Each of the 3 selectable combatant classes has unique attacks and stats.  Attacks can have a range of effects, including doing damage to the other combatants HP and altering the opposing combatants stat values.  At the beginning of each turn, both combatants HP and stats are printed in the console.  The game ends when one of the combatants HP drops to/below 0.

# How To Play
After cloning the repo, open a terminal and go to the projects root folder.  Once there, use ```dotnet run``` and the game will start in the terminal.  The game will ask each player select a combatant (Warrior, Mage, or Ranger).  Once each player has selected a combatant, the game will automatically start with each combatants HP at 100.  From there, each player will select attacks back and forth, until 1 combatant's HP has been fully depleted.  The game will then announce the winning player and the program will terminate.

# Future Additions
I hope to continue to build on and improve this game in the future.  Some features that I hope to add include usable items/equipment (for restoring HP and buffing stats), as well as further developing the attack index.  I am also looking to add/edit the current combatant classes to add for further variety in the game.
