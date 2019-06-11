# Game Basic Information #

## Summary ##

**Do you hate chicken? Do you love neon and cyberpunk-ish themes? Then this is the game for you!! With awesome, handpicked music and sound effects chosen by our team, you can slide around in a giant black box and shoot lasers at the hated, intensely neon blue chicken. But watch out! The chicken may have it's own lasers...**

## Gameplay explanation ##

**The goal is to kill the chicken before it can kill YOU! Slide around to dodge the chicken's lasers and shoot at it as fast as you can to win!**

**Movement: Use WASD or ARROW KEYS to slide around!**  
**Lasers: Use the MOUSE to aim and click the PRIMARY MOUSE BUTTON to shoot!**  
**Speed boost: Press SPACE to increase your speed!**  


# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based off the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your own relevant information. Liberally use the template when necessary and appropriate.

## User Interface

*Font Choice* - As UI designer, I wanted to create interfaces that conveyed information beyond mere numerical values. Since the theme of our game is “graduation,” I specifically wanted to communicate a juxtaposition between old and new, where the theme itself emerged from the dissonance between two aesthetics. For the main menu I used an elegant serif font to evoke classical ideas of classical pomp and circumstance, but for the game I used a blocky pixel font to conjure images of classic arcade games. This contrast serves as a visual analogy to the contrast our team feels as new graduates; we are expected to continue expressing our quirky uniqueness while existing next to standard uniformity.

*Player Health Indicator* - The player’s health meter has nuances besides the font choice as well. As one may notice, the text is not flush against the screen, it is angled in such a way that it points to the top-right of the screen. This was done to achieve certain effects. A specific detail I wanted to avoid was labeling the value “Player HP,” so I searched for ways to imply that visually. By angling it as I did, I tried to mimic the visual style of a heads-up display, the kind that one would see in a mech or in the Iron Man movies. The player should intuitively know that the value displayed belongs to themself. In addition, by placing the display near the bottom of the screen, it leverages the idea of perspective to convey that it is closer, and therefore, associated with the player. [Player Health Indicator Script](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Scripts/PlayerDataUIController.cs)

*Boss Health Indicator* - I had an opposite approach with the enemy health bar. By staying flat at the top of the screen, the enemy health bar gives the sense that the value is far away, belonging to an entity that is not the player. Coloring it red also implicitly establishes an air of aggression or threat, and the player is naturally inclined to perform actions that diminish the bar. An important detail is also the manner in which the health bar decreases. Instead of a standard right-to-left approach, I wanted feedback that emphasized how long the health bar was, and thus, how threatening the boss itself was. By having the decreasing from both ends towards the center, the boss health bar appears to be much larger, remaining an imposing line even as health is chipped away. This, in turn, makes the player feel as if they are defeating something powerful and imposing. [Boss Health Indicator script](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Scripts/BossHealthBarController.cs)

*Reticle* - there is the reticle for the player’s laser. Much like the font choice for the player HP, the reticle is purposefully blocky and “game-y” looking. While a smaller, thinner dot reticle akin to those found in Call of Duty and other first person shooters would be more beneficial, it would also imply some element of malice on the player character’s part. By using a cartoon reticle, it implies that player character is only participating in the game for fun.

## Movement/Physics

**player movement** - The player movement for the game fits our theme: facing off against a large challenge with no time to breathe. This was inspired by all of us graduating. The movement, once started, continues at the same speed in the same direction until other directional input is received. This movement was also inspired by other boss battles, such as the final boss in "Kirby Star Allies" and the rail-shooting boss from "Super Mario Sunshine". While brainstorming about the project, we considered having the player on rails the entire time. We thought this idea, while fun, could obfuscate our central theme of facing off alone against a large opponent. The idea of being on rails could thematically fit, as college is often a track that forces you along regardless of your decisions, but there was more agency (and fear) instilled in the player when given the option to navigate in whichever direaction they chose. 

Technically, this was accomplished with a script inspired by the `playerMovement.cs` script from the Obscura project earlier in the quarter. While that script took the horizontal and vertical input and set it to the direction of the player, this one checks for horizontal and vertical input, and then sets the player's direction to move in that direction (while the speed remains constant). This only allows for eight movement directions -- up, down, left, right, and each intermediate one if two keys are held down. This allows for a 'make your own rail' skating feeling of movement, fast with quick changes in direction, good for avoiding laser hits. 


**collisions** - All collisions in this game are standard, with no adjustments. Each object has a collider, and the player will not move if against an object (but, the player will keep their speed when they change direction -- this is done so the player wont slow down or stop once hitting a wall) This change was made to emphasize movement, as fancy collisions were unncessary to the vision of the game. 

**Lasers** - Each laser was done using a ray cast, so it was not invovled in my role of movement / physics. 

**Mouse Look** For this role, I coordinated with Bayan during our first playtest to come up with the best ways to combine our scripts, as I had done movement and she had done input and mouse look. We decided the movement and perspective of the player should be first person, with no inversion done to the mouse input direction. 

## Animation and Visuals

*Chicken* - The chicken consists of a variety of spheres, manipulated and transformed to represent the different parts of a chicken. I did use some chicken images as a reference. It was created with Maya. I did make a couple different versions. They look identical to each other, but the grouping of the objects is different. The default textures are replaced by textures I made in Unity. [Chicken Model](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Models/chicken.fbx)

*Textures* - I made most of them, as all I wanted were really simple and extremely neon colors. The team often mentioned a desire for a cyperpunk aesthetic, so I attempted it. It turned out really well, in my opinion. I did use a [texture](https://www.pinterest.com/pin/759630662124096867/) that I modified in photoshop for the walls and floors. [Materials folder](https://github.com/samclee/project-final-boss/tree/master/project-final-boss/Assets/Materials), [Modified image](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Images/867add3880a341a39051f5c1588f26ef.jpg)

*Animations* - I created a couple animations for the chicken in Maya. There's a looping idle animation where the chicken bobs a bit and flaps its wings. I also created an attack animation. It has a much larger bob (it floats up higher), the eyebrows draw into a frown, the beaks open, and the wings flap harder. For a short while, the eyebrows remain drawn together even after the mouth closes, before settling back into a neutral position. The attack animation plays as soon as the chicken fires a laser at the player. [Idle animation](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Animations/chickenIdle.fbx), [Attack animation](https://github.com/samclee/project-final-boss/blob/master/project-final-boss/Assets/Animations/chickenAttack.fbx), [Animation Script](https://github.com/samclee/project-final-boss/blob/b48bd6b24c83216948588ef6b7dfac39da64e38f/project-final-boss/Assets/Scripts/ChickenAnimation.cs#L25)

*Chicken Laser* - While Sam W. coded the laser, I moved it into the chicken's mouth and changed its color. The move to the mouth suggests to the player that the laser came out of the chicken's mouth, instead of a random spot nearby the chicken. I changed the color of the laser from neon pink to neon red because the player also had a neon pink laser, causing it to be confusing to differentiate player and chicken lasers. [Color change in script](https://github.com/samclee/project-final-boss/blob/b48bd6b24c83216948588ef6b7dfac39da64e38f/project-final-boss/Assets/Scripts/BossShootingController.cs#L35)

**The choice of colors leads to an arcade-ish vibe that's about speed and action. The heavy use of black in the chicken's coloring and the graph-like patterning of the walls makes the world feel more like a digital one, a lot like Tron. That, combined with the sliding moving mechanics, makes the game as a whole feel like a fast-paced game that never stops (because you literally can't stop).**

## Input

In this role, I was in charge of designing the game movement controllers. As a team, we discussed the most appropriate input for our game and we decided to make it from a first person perspective. This decision has been made for two main reasons. The first: given the intended narrative of the game, the main character of the game is the player themselves. So it made most sense to have it as a first person perspective. This also allowes the player to feel they're representing themselves. <br> 
And the second: given the shape and design of the level (round), and the boss in the middle, having the player's character in third perspective could be redundant visually because of the size of the battle stage. The first person perspective makes it way easier aiming, since this is our main mechanic for shooting. Also, we did not want to confuse the players on which character they control, given the fact there is only two characters (player + boss). 

Technically, I was responsible for writing a script to control the camera by the mouse. This has gone through several changes. My main difficulty was to get it correctly on the player's object to make it feel from a first person perspective. There are 2 major Vector variables: mouseLook, which tracks how much movement the camera made to add it later to the input (increment), and smooth, which helps making the movement smoother. There are 2 other variables for easy configuration: sensitivity and smoothing. To make the movement, first we get the moevement of the mouse (change of x and y), it's then multiplied by the sensitivity and smoothing values, and then the new values is used for transformation  of the axies.

Following a [Youtube](https://www.youtube.com/watch?v=bVo0YLLO43s) tutorial, I tried to add a "zoom in/out" functionality to allow the players to zoom in and out to get near and far from the boss as shown [here](https://github.com/samclee/project-final-boss/blob/eb4c869d6ee13e35850d532a7a89e56c3d25ec3a/project-final-boss/Assets/Scripts/CameraOrbit.cs#L48), however, after testing, this feature was redundant (no one used it), and it was difficult to adapt to by the players because the mouse had too many options (rotating the camera, shooting, and zooming in/out), so I decided to remove it. 

Last but not least, after testing, we realized playtesters had some trouble with controlling the camera, especially because of the sensitivity. Luckily, since the sensitivity it's just a variable, the issue has been fixed by increasing the variables number only as shown [here](https://github.com/samclee/project-final-boss/blob/eb4c869d6ee13e35850d532a7a89e56c3d25ec3a/project-final-boss/Assets/Scripts/CameraMouse.cs#L10).

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

1. "sfx_exp_short_hard8" from [The Essential Retro Video Game Sound Effects Collection](https://opengameart.org/content/512-sound-effects-8-bit-style) (Creative Commons)
2. "sfx_wpn_laser7" from [The Essential Retro Video Game Sound Effects Collection](https://opengameart.org/content/512-sound-effects-8-bit-style) (Creative Commons)
3. "Rapid2" from [PeriTune](https://soundcloud.com/sei_peridot/rapid2) (Attribution 4.0 International (CC BY 4.0) )

*Audio System* - The audio system uses an array of Audio Sources loaded onto the player. Whenever the player shoots or lands a direct hit they are aware and can trigger the appropriate sound. [Audio Source array](https://github.com/samclee/project-final-boss/blob/1d1654893125c5630260d3214fdf6159ac0ebb1d/project-final-boss/Assets/Scripts/PlayerShootingController.cs#L37)

The sound style is meant to be exciting and provide visceral feedback for the player's actions.

## Gameplay Testing

Comments from playtesters:
* Jack: The shooting didn't feel accurate, like it wasn't shooting into the middle of the screen. Wasn't sure if the chicken was doing anything. (At the time, the chicken wasn't moving and the laser was the same color as the player's, so it was hard to tell)
* Michael: Shooting seems buggy, would prefer an ability to jump instead of speed boosting. Enjoyed the quick pace of the movement though and really liked the music.
* Aleah: The movement reminded her of an older Nintendo Playstation game (she mentioned specifically Thousand Arms). She liked the movement. She didn't have any particular criticisms other than that the mouse cursor was visible and distracted her from the UI cursor. Also suggested adding a ceiling.
* Tiange: Music reminds her a lot of pokemon. The chicken (she called it a penguin) was really cute and the music was cool. When asked about the movement, she said that it was *unique*, but couldn't decide if that was a good or bad thing.
* Andrew: The camera swings around so quickly, the mouse sensitivity seems very high. That, combined with the quick movement, induced some motion sickness. However, he thinks that the craziness would be fun for other people.
* John: Mouse sensitivity was too high, he was facing walls more often than the chicken. The end screen at the time was just a blank screen as well, so that was very abrupt. Altogether, a very disorienting experience.
* Cindy: The mouse sensitivity is too high. The music is nice and she really liked the stylized design of the player's HP.
* Jeff: Also thought that the mouse sensitivity was too high. Can't tell when he's successfully hitting the chicken. Also, for some reason, fell out of the arena multiple times by phasing through the walls.
* Daisy: Thought the colors were kinda cool. Enjoyed the music. She liked the sliding, it made the game more difficult to play (for a small game, giving the player something extra to manage is a good thing).
* Le: Mouse sensitivity is too high, gives her a slight headache. It's fun when she's just sliding forwards and backwards without moving the mouse. She noticed that the laser came out of the chicken's mouth and that the chicken looked mad.

**Movement was a hit or miss. Some people enjoyed the sliding, others felt uncertain about it. A couple people mentioned that the shooting seemed buggy, either due to aim or length. Audio in general was very much enjoyed. Noticed that Windows users had a really tough time with the mouse sensitivity. Realized that since I was mostly testing with the school Macs, which had really low mouse tracking speeds by default, I didn't notice how wildly the camera moved.**

## Narrative Design

During our first brainstorming session as a team, we noticed that most of the group is graduating and thus we wanted to make a game that reflects this milestone. Thus, this game was inspired by leaving our undergraduate stay at the University of California, Davis. Like the player, we've spent the past several years trying to overcome the obstacle of university, which in the game is represented by a Chicken model to convey the emotion of "fear". Our movement was never halting (and thus movement in the game is similar to skating rather than walking), our inertia unforgiving, and our visuals  absurd, but we created moments to carry with us beyond just our undergraduate careers. These feelings were reflective in the game design choices was made to convey these emotions. 

## Press Kit and Trailer

**Game Trailer** - https://youtu.be/drgOPesCuJU
**Press Kit** - https://jwhop.itch.io/project-final-boss password: final_project

Important in starting the trailer for this game was setting the game's tone. To accomplish this, I overlayed a hearbeat sound effect with a camera panning down to expose the boss. Once the boss shot at the player, the movement started as well as the music. This was done to 'hook' the player in, providing a moment of stillness before the action began. 

From there, we have several clips displaying movement and shooting mechanics. The clips progress logically, from initial movement, to avoiding enemy attacks, to developing a strategy, and finally carrying out a strategy to attack and win the game. To better illustrate this, each clip had an overlayed text to further explain how the game worked. 

The press kit used a popular independent game distribution system itch.io to showcase the game. There, we posted a link to download an executeable of the game, and included screenshots to show different angles of the boss (implying movement) as well as screenshots with the laser to show the combat system.



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
