Game 1
=====

In this project you will learn how to create the basic controls for your project.

We will discuss how things work, so you can remix the settings and add the tweaks which will make your game unique.


## Steps

_Get your characters ready:_

1. create your sprites and add them to the page via "add sprite" menu option
We will now need to set up your player so you can move around

_Add Lights_

2. add lights (via the GameObject -> add Directional Light)

_Add Player Controls_

3. attach your camera to your player sprite (drag and drop in the heirarchy column)
  1.  add a box collider (and rigid body if you want) to your player sprite for events
  2. add `Movement_Player.cs` to your player sprite
  3.  remember to click the `is Trigger` option

:sparkles: **Try your game out so far.** :sparkles:


## Procedure for making triggers

sometimes you want stuff to happen.


#### Collisions

If you do then you will like to add Physics2D colliders to the objects when they collide.
Afterwards place the `Trigger_Collision_Audio.cs` on the object your player walks into,
and you may either have it play the object's audio (add component -> audio -> then just add the sound file we have in the assets folder), or anything else you can wish.

REMEMBER to add the collider and to toggle the `isTrigger` box.
