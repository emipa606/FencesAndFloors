# GitHub Copilot Instructions for RimWorld Mod: Fences and Floors

## Mod Overview and Purpose
The "Fences and Floors" mod enhances the construction possibilities in RimWorld by introducing new types of fences and flooring options. The primary goal is to provide players with more aesthetic and functional choices for base-building, thereby enriching the gameplay experience. By expanding the variety of construction materials and methods, players can create more unique and individualized colonies.

## Key Features and Systems
- **Diverse Fencing Options**: Adds various types of fences that not only serve as barriers but also influence gameplay through factors like cost, durability, and beauty.
- **Flooring Variety**: Introduces new flooring materials that offer different visual styles and benefits, enhancing both the utility and aesthetics of player bases.
- **Enhanced Gameplay Mechanics**: Integration with pathfinding and construction cost calculations to ensure seamless gameplay and AI interaction.

## Coding Patterns and Conventions
- **Namespace Usage**: All classes related to the mod modules should be placed under a coherent namespace for organization, such as `FencesAndFloors`.
- **Basic C# Structure**: Follow typical C# structuring with appropriate access modifiers (private, public, internal) as shown in `FencesAndFloors_Initialization` class and `PathGrid_CalculatedCostAt` static class.
- **Static Classes and Methods**: Use static classes to encapsulate methods related to pathfinding and calculations to avoid unnecessary instantiations (e.g., `PathGrid_CalculatedCostAt`).

## XML Integration
- XML is used extensively in RimWorld modding for defining new buildings, including fences and floors.
- XML definitions should be organized in a way that syncs with mod features, focusing on building definitions (`<ThingDef>`), graphic data, and recipes.
- Maintain consistent naming conventions and ensure all XML tags map correctly to C# classes for behavior and property definitions.

## Harmony Patching
- Harmony is used to patch existing game methods to extend or modify their behavior. This is crucial for integrating new pathfinding costs and construction logic without altering the base game.
- Each patch should be well-documented within the C# files, with clear comments on the purpose and expected outcome of each Harmony patch.
- Example: Patch `PathGrid_CalculatedCostAt` to adjust pathfinding cost calculations when new flooring is implemented.

## Suggestions for Copilot
- **Generate Helper Functions**: Use Copilot to create additional helper functions that streamline the integration between C# logic and XML data.
- **Automate Repetitive Code**: Use Copilot to reduce the manual workload by automating repetitive patterns, such as initialization logic for new wall types.
- **Commenting and Documentation**: Encourage Copilot to generate inline comments and XML documentation to maintain high code readability and maintainability.
- **XML Code Generation**: Assist in generating XML for new defenses and flooring items by suggesting base templates that align with existing conventions.
- **Testing Assistance**: Use Copilot to draft unit tests that ensure new features function correctly within the game environment, with a focus on construction and pathfinding mechanics.

By following these guidelines, developers can efficiently use GitHub Copilot to assist with the creation and maintenance of the "Fences and Floors" mod, leveraging AI to enhance coding productivity and product quality.
