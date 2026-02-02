# Farmers Market — OOP Final Project

## Project Background
The **Farmers Market** game was developed as the Final Project for the **Object-Oriented Programming (OOP)** course. It serves as a platform for students to implement OOP concepts in a functional software product, in this case a farming simulation game.

## Depth of Mechanics and Gameplay
The game is designed to give players the experience of a modern farmer through multiple layers of interaction:

- **Precise Grid System**: Core interactions take place on tile-based land. Players must accurately position the cursor to till soil, plant seeds, water crops, and harvest.
- **Progressive Challenges**: The game offers a progressive difficulty curve. Success depends on strategic decisions, such as choosing which seeds to buy and when to upgrade tools for efficiency.
- **Market Dynamics**: The game includes a dynamic market system where buy/sell prices fluctuate, requiring players to develop strong economic strategies.

## OOP Principles Implemented
The project applies the four main pillars of OOP in its code architecture:

- **Encapsulation**: Sensitive data is protected from arbitrary external access, for example managing crop type visibility in `CropController` and sleep state in `BedController`.
- **Polymorphism**: Seen in the `UpdateDisplay` function within `InventoryController`, where the system uniformly updates different objects (seeds and harvest results).
- **Singleton Pattern**: Applied to core controllers such as `PlayerController`, `GridController`, and `AudioManager` to ensure only one global instance manages game logic.
- **Abstraction**: Separates complex internal logic (such as time calculations or grid positioning using `Mathf`) from the user interface, so players only see the final results on screen.

## Technology Stack
- **Engine**: Unity
- **Language**: C#

## Demo
https://youtu.be/jJ4wV9PPlaE?si=TAM5HXKV5M8se3hx

## Project Structure (Brief)
- **Assets/**: Game resources (scripts, prefabs, scenes, audio, etc.)
- **Packages/**: Unity package dependencies
- **ProjectSettings/**: Unity project configuration

## Notes
This document focuses on the academic context and game design. See **Assets/Scripts** for detailed class implementations and OOP architecture.

## Game Identity / Mantra
Interactive and strategic farming simulator with grid-based planting that emphasizes economic management and player growth through engaging gameplay mechanics.

## Design Pillars
- Dynamic farming with grid-based planting and crop management.
- Progressive challenges that simulate real-world farming decisions.
- Rewarding economic and inventory management systems.

## Genre / Story / Mechanics Summary
Farmers Market is a 2D farming simulator where players experience the life of a modern farmer. The game focuses on grid-based planting, harvesting, and selling crops, combined with strategic decisions around buying seeds, upgrading tools, and managing finances. Players interact with a virtual market to sell produce, buy resources, and unlock tools that improve farming efficiency. A progressive difficulty curve—through seasons, crop growth, and market trends—challenges players to adapt and thrive.

## Features
- **Full Player Movement**: Smooth character movement across the farm.
- **Planting and Growing Crops**: Plant seeds, water crops, and observe growth stages before harvesting.
- **Grid-Based Planting**: Tile-based interactions for plowing, planting, watering, and harvesting with precision.
- **Tool Management**: Tools like watering cans and axes improve efficiency and enable different farming actions.
- **Inventory System**: Limited inventory encourages planning; the UI shows total storage for seeds and crops.
- **Buying and Selling Seeds and Crops**: Purchase seeds (minimum 1, maximum 10 per type) and sell harvests in a dynamic market.
- **Day–Night Cycle and Seasons**: Time system affects crop growth and market conditions; seasons add variety and challenges.
- **Tracking Money**: Real-time updates to player funds in the UI.
- **Full Menu and Audio Systems**: Menus for settings, stats, and pause; audio for ambience, music, and SFX.

## Interface
- **Player Input**: On PC, movement uses WASD or arrow keys. Actions (planting, harvesting, tool switching, market transactions) use mouse clicks. Keyboard shortcuts enable fast tool switching and inventory access.
- **Player Interaction**: Grid-based tile selection supports precise farming actions. A dynamic tool indicator helps target tiles from a distance. The UI includes clear indicators for money, time, and tool selection to keep gameplay readable and engaging.

## Art Style
- **Reference**: James Doyle’s “Tiny Wonder Farm” asset pack.
- **Links**:
	- https://butterymilk.itch.io/tiny-wonder-farm-asset-pack
	- https://itch.io/t/2377117/-tiny-wonder-farm-is-live
- **Visuals**: Vibrant 2D pixel art with a cheerful outdoor setting. Simple, stylized character and tools, with a clear grid layout and a bottom UI for tools and inventory.

## Music & Sound
- **Music**:
	- “Apple Cider” — loading screen theme with joyful, exciting tone.
	- “Hometown” — peaceful suburban farming atmosphere.
		- https://archive.org/details/JuhaniJunkala-JRPGpack2Town/Town1+-+Home+Town.ogg
	- “Where Time Stands Still” — calm, reflective farming-life theme.
		- https://archive.org/details/JuhaniJunkala-JRPGpack2Town/Town2+-+Where+Time+Stands+Still.ogg
	- “Bazaar” — celebratory theme inspired by culinary vibes.
		- https://archive.org/details/JuhaniJunkala-JRPGpack2Town/Town4+-+Bazaar.ogg
- **Sound FX**:
	- Wake Up / Day End: alarm-like cues for daily rhythm.
	- Plant / Plough / Water: tactile farming interactions.
	- Pick Up / Chest Buy / UI Select: feedback for item actions and UI navigation.

## Development Roadmap / Launch Criteria
- **Target Platforms**: Steam / Google Play / iOS / Web
- **Audience**: Casual gamers and farming enthusiasts, ages 10+
- **Milestones**:
	- Milestone 1: Core mechanics complete (grid planting, crop growth, harvesting)
	- Milestone 2: Tool management system (tool upgrades and unique functions)
	- Milestone 3: Market system (buy/sell crops with dynamic prices) 
	- Milestone 4: Day–night cycle and seasonal changes (weather and time mechanics)
	- Milestone 5: Finishing up (visuals, animations, sound effects)


## Team Responsibilities
- **Azka Nabihan Hilmy (2306250541)**: Milestone 1, Milestone 5
- **Dwigina Sitti Zahwa (2306250724)**: Milestone 1, Milestone 2, GD, PPT
- **Audy Natalie Cecilia Rumahorbo (2306266962)**: Milestone 4, PPT
- **Aliya Rizqiningrum Salamun (23062161813)**: Milestone 3, GD, PPT
