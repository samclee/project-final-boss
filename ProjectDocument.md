# Game Basic Information #

## Summary ##

**Do you hate chicken? Do you love neon and cyberpunk-ish themes? Then this is the game for you!! With awesome, handpicked music and sound effects chosen by our team, you can slide around in a giant black box and shoot lasers at the hated, intensely neon blue chicken. But watch out! The chicken may have it's own lasers...**

## Gameplay explanation ##

**The goal is to kill the chicken before it can kill YOU! Slide around to dodge the chicken's lasers and shoot at it as fast as you can to win!**

**Movement: Use WASD or ARROW KEYS to slide around!
Lasers: Use the MOUSE to aim and click the PRIMARY MOUSE BUTTON to shoot!
Speed boost: Press SPACE to increase your speed!**


# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based off the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your own relevant information. Liberally use the template when necessary and appropriate.

## User Interface

**Describe your user interface and how it relates to gameplay. This can be done via the template.**

## Movement/Physics

**Describe the basics of movement and physics in your game. Is it the standard physics model? What did you change or modify? Did you make your own movement scripts that do not use the phyics system?**

## Animation and Visuals

*Chicken* - The chicken consists of a variety of spheres, manipulated and transformed to represent the different parts of a chicken. I did use some chicken images as a reference. It was created with Maya. I did make a couple different versions. They look identical to each other, but the grouping of the objects is different. The default textures are replaced by textures I made in Unity. [Chicken Model](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Models/chicken.fbx)

*Textures* - I made most of them, as all I wanted were really simple and extremely neon colors. The team often mentioned a desire for a cyperpunk aesthetic, so I attempted it. It turned out really well, in my opinion. I did use a [texture](https://www.pinterest.com/pin/759630662124096867/) that I modified in photoshop for the walls and floors. [Materials folder](https://github.com/samclee/project-final-boss/tree/master/project-final-boss/Assets/Materials), [Modified image](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Images/867add3880a341a39051f5c1588f26ef.jpg)

*Animations* - I created a couple animations for the chicken in Maya. There's a looping idle animation where the chicken bobs a bit and flaps its wings. I also created an attack animation. It has a much larger bob (it floats up higher), the eyebrows draw into a frown, the beaks open, and the wings flap harder. For a short while, the eyebrows remain drawn together even after the mouth closes, before settling back into a neutral position. The attack animation plays as soon as the chicken fires a laser at the player. [Idle animation](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Animations/chickenIdle.fbx), [Attack animation](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Animations/chickenAttack.fbx), [Animation Script](https://github.com/samclee/project-final-boss/blob/b48bd6b24c83216948588ef6b7dfac39da64e38f/project-final-boss/Assets/Scripts/ChickenAnimation.cs#L25)

*Chicken Laser* - While Sam W. coded the laser, I moved it into the chicken's mouth and changed its color. The move to the mouth suggests to the player that the laser came out of the chicken's mouth, instead of a random spot nearby the chicken. I changed the color of the laser from neon pink to neon red because the player also had a neon pink laser, causing it to be confusing to differentiate player and chicken lasers. [Color change in script](https://github.com/samclee/project-final-boss/blob/b48bd6b24c83216948588ef6b7dfac39da64e38f/project-final-boss/Assets/Scripts/BossShootingController.cs#L35)



**Describe how your work intersects with game feel, graphic design, and world-building. Include your visual style guide if one exists.**

## Input

**Describe the default input configuration.**

**Add an entry for each platform or input style your project supports.**

## Game Logic

**Document what game states and game data you managed and what design patterns you used to complete your task.**

# Sub-Roles

## Audio

**List your assets including their sources, and licenses.**

**Describe the implementation of your audio system.**

**Document the sound style.** 

## Gameplay Testing

**Add a link to the full results of your gameplay tests.**

**Summarize the key findings from your gameplay tests.**

## Narrative Design

**oDocument how the narrative is present in the game via assets, gameplay systems, and gameplay.** 

## Press Kit and Trailer

**Include links to your presskit materials and trailer.**

**Describe how you showcased your work. How did you choose what to show in the trailer? Why did you choose your screenshots?**



## Game Feel

**Document what you added to and how you tweaked your game to improve its game feel.**
