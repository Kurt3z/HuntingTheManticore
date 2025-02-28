# Hunting The Manticore

## This is a project in the scope of [RB Whitaker - The C# Player's Guide Book](https://csharpplayersguide.com/)

### This was the project challenge of **Part 1 - The Basics**

Text and turn based game that simulates a rocketship invasion on the city of Consolas. The game contains multiple rounds that will play
until either the city or the rocketship are destroyed.

#### Challenge Storyline

> The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be
> destroyed, or the city will fall. Only by combining Mylara’s prototype, Skorin’s cannon, and your
> programming skills will you have a chance to win this fight. You must build a program that allows one
> user—the pilot of the Manticore—to enter the airship’s range from the city and a second user—the city’s
> defenses—to attempt to find what distance the airship is at and destroy it before it can lay waste to the
> town.

#### Rules and Mechanics

1. The rocketship positions itself in a space that is represented by a number between 1-100.
2. The City starts with 15 HP. The Manticore starts with 10HP.
3. Every round the city defenders try to guess where the Manticore is positioned.
4. If the round number is a multiple of 3, the city defenders will deal 3 damage to the Manticore.
5. If the round number is a multiple of 5, the city defenders will deal 3 damage to the Manticore.
6. If the round number is a multiple of 3 and 5, the city defenders will deal 10 damage to the Manticore and win the game.
7. The other rounds the city defenders deal 1 damage to the Manticore.
8. Every round the Manticore deals 1 damage to the city.
9. The game ends when either the city or the Manticore HP reaches 0.
