# Vitamin Deposu Game

## Description
"Vitamin Deposu" is a Windows Forms application developed in C# which uses the principles of Object-Oriented Programming (OOP). The game involves processing various fruits to determine their Vitamin A and Vitamin C contents based on their weights and the type of juicer used.

## Features
- Supports both citrus fruits (e.g., Orange, Tangerine, Grapefruit) and solid fruits (e.g., Apple, Pear, Strawberry).
- Each fruit has defined values for Vitamin A, Vitamin C, and weight (in grams).
- Different yield percentages for citrus (30-70%) and solid fruits (80-95%).
- Real-time vitamin values calculation based on the juice/puree obtained.
- 60-second countdown timer after pressing the start button.
- Random generation of fruits within a weight range of 70-120 grams.
- Dynamic UI representation of the selected fruit.
- Accurate juicer selection for the fruit type.
- Continuous game process until the timer runs out, showcasing total vitamin content and total juice/puree.

## File Structure
Ensure fruit images are in the same directory as the `.exe` file for proper rendering during project execution.

## Fruit Vitamin Values (per 100g)
| Fruit     | Vitamin A (iu) | Vitamin C (mg) |
|-----------|----------------|----------------|
| Orange    | 225            | 45             |
| Tangerine | 681            | 26             |
| Grapefruit| 3              | 44             |
| Apple     | 54             | 5              |
| Pear      | 25             | 5              |
| Strawberry| 12             | 60             |

## Class Design
OOP principles should be strictly adhered to. Each entity in the game should be represented by a class. Inheritance should be leveraged where appropriate. The usage of interfaces, abstract classes, and other OOP concepts is recommended. The code should demonstrate a clear understanding of OOP.

## Setup & Execution
*Details on how to set up and run the application will go here, including any prerequisites or dependencies.*

## Contributing
Contributions, issues, and feature requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
*Specify your license here.*

## Acknowledgments
*Credit to anyone who contributed or provided resources.*
