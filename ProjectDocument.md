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
*Game States*:
* *TitleScene*: The first game state is the title scene. Upon pressing the
  “Begin” button, the player is taken to the main GameScene.
* *GameScene*: The scene in which all of our gameplay takes place. As outlined
  above, it is here that the player has the affordances of shooting, boosting,
  and moving to work towards defeating the Chicken. Upon depleting all of the
  Chicken’s health, the player is taken to the GameWin Scene. If the player’s
  health reaches 0, they’re taken to the GameOver Scene. The player has no
  option to return to the title scene.
* *GameWin*: The player is greeted with a congratulatory message, and given the
  option to replay the boss fight with the click of a button prompt.
* *GameOver*: The player is greeted with a message, and given the option to
  retry the boss fight with the click of a button prompt.

*Game Data*:
* *Player Health*: The player begins with 100% health. Each time the player is
  hit by the Chicken’s laser, their health is decremented by 20%. This is
  communicated to the player through text reading “HP: ___%” in the lower left
  hand corner of the player’s point of view.
* *Boss (Chicken) Health*: The Boss begins with 100% health. Each time the
  player is hit by the Chicken’s laser, their health is decremented by 5%. This
  is communicated to the player through the BossHealthBarCanvas: a large, red,
  horizontal bar in the top of the GameScene UI. 

*Design Patterns*:
* *Command Pattern*: For the sake of the relatively limited scope of our
  project’s game systems, and since there only exist two primary interacting
  entities, I chose to use a pseudo-Command Pattern. This was roughly based off
  of Programming Exercise 1, and the several different abilities offered to the
  Captain. 
    * *Player*:
        * *Movement*: Our player’s movement is managed by the SimpleMovement
          script
        * *Camera*: The player’s first-person camera is managed by the
          CameraMouse script.
        * *Shooting*: The player’s laser-shooting mechanic is managed by the
          PlayerShootingController script, which [uses raycasts to detect
          colliders](https://github.com/samclee/project-final-boss/blob/c2cfa65451ea3c973905825218e00af037aca1d5/project-final-boss/Assets/Scripts/PlayerShootingController.cs#L66)
          that it intersects with, simulating a laser. 
        * *Health*: The player’s health is managed by the
          PlayerDataUIController, which exists on a child GameObject of the
          Player object. Its public method,
          [Damage](https://github.com/samclee/project-final-boss/blob/c2cfa65451ea3c973905825218e00af037aca1d5/project-final-boss/Assets/Scripts/PlayerDataUIController.cs#L23),
          is [invoked by the
          BossShootingController](https://github.com/samclee/project-final-boss/blob/c2cfa65451ea3c973905825218e00af037aca1d5/project-final-boss/Assets/Scripts/BossShootingController.cs#L75)
          when a laser connects.
    * *Boss (Chicken)*:
        * *Movement*: The boss’s movement is managed by the ChickenAnimation
          script
        * *Shooting*: The boss’s [laser-shooting
          mechanic](https://github.com/samclee/project-final-boss/blob/c2cfa65451ea3c973905825218e00af037aca1d5/project-final-boss/Assets/Scripts/BossShootingController.cs#L65)
          is managed by the BossShootingController script. For a simple AI, this
          controller makes our boss [fire its laser every 4
          seconds](https://github.com/samclee/project-final-boss/blob/c2cfa65451ea3c973905825218e00af037aca1d5/project-final-boss/Assets/Scripts/BossShootingController.cs#L40).
        * *Health*: The boss’s health is managed by the BossHealthBarController,
          which exists on a child GameObject of the Boss object. Its public
          method,
          [Damage](https://github.com/samclee/project-final-boss/blob/c2cfa65451ea3c973905825218e00af037aca1d5/project-final-boss/Assets/Scripts/BossHealthBarController.cs#L21),
          much like the player’s, is [invoked by the
          PlayerShootingController](https://github.com/samclee/project-final-boss/blob/c2cfa65451ea3c973905825218e00af037aca1d5/project-final-boss/Assets/Scripts/PlayerShootingController.cs#L79)
          when a laser connects.
    * *Explanation/ Design Process*:
        * I originally attempted to take full advantage of the reusability of
          the command pattern by having the player and boss utilize the same
          laser-shooting script, as well as the same health script, but later
          decided to separate them for the sake of the Single-Responsibility
          Principle. If, however, we expanded upon this project, we could’ve
          reused our PlayerShootingController for additional players, and our
          BossShootingController for additional sub-enemies.


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
Since our game revolves entirely around the interactions between the player and
the boss, and my main contribution was the shooting logic, I decided to
primarily tweak aspects of that in an iterated approach to improve game feel. By
focusing on making the shooting interactions more varied and deliberate, I
believe that the overall replay-ability and game feel will be improved.
Originally, we planned to have the player and boss have the ability to shoot
each other from location in our arena. This proved to be a minor issue, since we
wanted to emphasize and incentivize smooth and constant movement around the
arena. For this reason, I thought it would make more sense to force the player
to approach the chicken in close proximity to deal damage. Thus, I reduced the
player weapon range to a fraction of what it was before, as well as also
reducing the chicken’s laser range such that it always aimed towards the player,
but could only hit them within a smaller radius. This way, the player could be
damaged if they stayed close to the chicken for an extended period of time, but
could utilize their boost to weave in and out and develop and pattern of safely
dealing damage with the right timing. To further incentivize tight timing and
risks, I further increased the player’s fire rate so they could just barely
shoot the chicken twice before moving or boosting out of its fire range. To
continue with the idea of incentivizing fast-paced gameplay and risk-taking, the
boss’s shooting mechanics only allow its laser to reach the player within a
certain radius, so the player can repeatedly deal damage to the chicken if they
keep moving in such a way that they stay directly behind the chicken. Our
intentionally-slippery movement makes this a challenge, but a definite
possibility for players who may aim for speed over safety.
