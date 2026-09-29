# GitHub Copilot Instructions for Fences And Floors (Continued) Mod

## Overview and Purpose
The "Fences And Floors (Continued)" mod revitalizes Captain Staky's original modification for RimWorld, further enhancing the gameplay with new flooring styles and fences. The mod aims to integrate seamlessly with the core game mechanics, providing players with additional construction options that imbue both aesthetic and functional enhancements to their colonies.

## Key Features and Systems
- **New Flooring Styles:** Introduces four new flooring types, each with unique attributes and purposes, including sensor panels which dynamically increase pawn movement speed.
- **Enhanced Fencing Options:** Four distinct fences, including chainlink and high-security variants, with specific use cases such as improving defense and providing firing cover.
- **Research Integration:** New research projects unlock advanced flooring options, integrating with RimWorld's existing technology progression system.
- **Improved Balancing:** Version 1.21 includes a balance pass that recalibrates material and construction requirements as well as hitpoints (HP) to ensure consistency with vanilla RimWorld assets.

## Coding Patterns and Conventions
- **C# Code Structure:** 
  - Organized by features in separate files to promote readability and maintenance (e.g., `PathGrid_CalculatedCostAt.cs` for path cost handling and `FencesAndFloors_Initialization.cs` for mod initialization).
  - Use of clear and descriptive method names, such as `MovementTicksAddOnIgnoreZero` and `Transpiler`, to convey functionality.
  
- **XML File Organization:** 
  - Structured logically by feature, such as terrain, research projects, and fences, to facilitate easy navigation and modification.
  - XML files typically contain definitions (`Defs`) that are directly integrated into RimWorld’s existing systems (e.g., `DesignationCategoryDef` and `ThingDef`).

## XML Integration
- **DesignationCategoryDef:** Defines new designation categories for in-game construction menus, streamlining user experience.
- **ResearchProjectDef:** Introduces new research requirements, ensuring a progression-based unlocking of added features.
- **TerrainDef and ThingDef:** Customizes floorings and fences with appropriate stats and properties, defining their in-game behavior and interactions.

## Harmony Patching
- **Dependencies:** This mod utilizes the Harmony library to inject additional functionality or modify existing game code without altering the base game files.
- **Example Patch File:** `UNColony_Patch.xml` demonstrates how patches are applied to expand or adjust game mechanics, ensuring compatibility with other mods and updates.

## Suggestions for Copilot
- **Autocomplete Snippets:** When writing C# code related to mod features, Copilot can suggest snippets for typical Harmony patches or common patterns in XML definition files.
- **Inline Documentation:** Provide comments within the C# and XML files to ensure explanations are readily available for each piece of code, aiding Copilot in generating context-aware suggestions.
- **Conventional Naming:** Use consistent and descriptive naming across all codebases (e.g., "FAFResearchProjects") to enhance Copilot’s suggestion relevance and accuracy.

By adhering to these guidelines and leveraging advanced AI tools like GitHub Copilot, developers can streamline their mod development process, ensuring consistency and integration within the vibrant modding community for RimWorld.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

