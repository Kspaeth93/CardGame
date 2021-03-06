# CardGame
A simple card game simulation written in C#.
## Features
- Create a representation of a deck of cards.
- Ability to shuffle cards.
- Ability to draw a card from the deck.
- Create a data structure representing a board to hold 10 cards.
- Simulate playing a simple card game.
- View simulation statistics. (Time elapsed, Wins, Losses)
## Game Description
1. Draw a card from the deck.
2. Place the card anywhere on the board.
3. Repeat this process - you can not add a card with the same face value to the board.
4. If you draw a card with a duplicate face value, it must be discarded.
5. Cards on the board must be kept in sequential order.
6. If you fill the board with 10 different face values before you discard too many cards, you win.
## Sample Output
```Total time: 215 milliseconds
Total wins: 4540
Total losses: 5460
Win probability: 45.4%
```
## Sample Data
```
Run 01: 44.40%
Run 02: 72.34%
Run 03: 33.36%
Run 04: 48.62%
Run 05: 70.84%
Run 06: 27.84%
Run 07: 32.17%
Run 08: 36.00%
Run 09: 57.32%
Run 10: 44.54%
Total: 46.473%
```
## Other Notes
Please run the simulation multiple times to get a better feel for the results. I assumed that the cards could be moved around on the board in order to keep them in sequential order - thus adhering to the rules.
