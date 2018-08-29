# 06-Laser-Defender
In this section we create a lively top-down space shooter, learning coroutines, waypoints, scriptable objects, and more. This repo is part of our Complete Unity C# Developer 2D course (http://gdev.tv/cudgithub). (Ref: LD_CUD)

# Complete Unity Developer 2D - Laser Defender

This is the [Complete Unity Developer](http://gdev.tv/cudgithub) - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects and our latest teaching techniques. You will benefit from the fact we have already taught nearly half a million students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo. You can check out the course here: [Complete Unity Developer](http://gdev.tv/cudgithub)

## In This Section
In this section we create a dynamic top-down shooter using everything Unity has to offer - waypoints for enemy paths, wave configuration using Scriptable Objects, coroutines for timed events, and more. (Ref: LD_CUD)

## How To Build / Compile

## Lecture List
Here are the lectures of the course for this section.


### 1 Welcome To Laser Defender ###

**In this video (objectives)…**

1. Overview of this section.
2. Focus on making a fun top-down shooter.
3. Lots of creative opportunity to make your flavour of top-down shooter.

**After watching (learning outcomes)…**
Ready and raring to start this section.


### 2 Laser Defender Game Design ###

**In this video (objectives)…**

1. Discuss the features, player experience and core loop in our game.

**After watching (learning outcomes)…**
You'll know exactly what we're making and you'll need to do to get started.


### 3 Set Up Project ###

**In this video (objectives)…**

1. Create new Unity project.
2. Download art assets and import them.
3. Set up background, player, enemy, camera and aspect ratio to find something we are happy with.

**After watching (learning outcomes)…**
Create our project and be happy with the aspect ratio, sizes and proportions.


### 4 Movement & Time.deltaTime ###

**In this video (objectives)…**

1. Move the player on horizontal axis using Input.GetAxis().
2. Use Time.deltaTime to make our game framerate independent.
3. Also add vertical movement for the player.

**After watching (learning outcomes)…**
Move your player ship in a way which is frame rate independent.


### 5 ViewPortToWorldPoint() ###

**In this video (objectives)…**

1. Construct our gameplay boundaries using the method ViewPortToWorldPoint().
2. Clamp our horizontal and vertical movement based upon our boundaries.
3. Add padding so that the player does not go off screen.

**After watching (learning outcomes)…**
Limit your player's ship movement based upon relative camera space.


### 6 What Feature Next ###

**In this video (objectives)…**

1. Map out all the core and secondary features in our game and the main polish areas.
2. Identify our options for priorities and select our next feature to work on.

**After watching (learning outcomes)…**
Understand the thought process for identifying your priorities for development.


### 7 Make Player Shoot ###

**In this video (objectives)…**

1. Create a projectile and connect it to the player.
2. Instantiate a the projectile using GetButtonDown().
3. Give the projectile some velocity so that it shoots upwards.

**After watching (learning outcomes)…**
Instantiate a project and shoot it upwards.


### 8 Using Coroutines ###

**In this video (objectives)…**

1. Understand the core concept of how a coroutine works.
2. Create a simple coroutine that prints to the console, yields for 3 seconds, then prints to the console again.

**After watching (learning outcomes)…**
Understand the basics of how coroutines work.


### 9 Repeat Fire Coroutine ###

**In this video (objectives)…**

1. Create a coroutine to call when firing.
2. Loop the coroutine using a while (true) loop.
3. Create a means in which to stop the coroutine.

**After watching (learning outcomes)…**
Use coroutine to create repeating fire when the player is holding down the shoot button.


### 10 GameObject Shredder ###

**In this video (objectives)…**

1. Create Shredder object and script.
2. Test for trigger and then destroy object which collided.

**After watching (learning outcomes)…**
Able to destroy GameObjects which collide with our trigger volume.


### 11 Create List Of Waypoints ###

**In this video (objectives)…**

1. Create empty game objects to use as waypoints.
2. Introduce lists and how they are different to arrays.
3. Store our path waypoints in our list.

**After watching (learning outcomes)…**
Create a list to store enemy path waypoints.


### 12 Move Enemy On Path ###

**In this video (objectives)…**

1. Write pseudocode for our enemy movement.
2. Use the MoveTowards() method to move the enemy.

**After watching (learning outcomes)…**
Move an enemy GameObject along a path using waypoints.


### 13 WaveConfig Scriptable Object ###

**In this video (objectives)…**

1. Map out what data will need to be in which of our scripts.
2. Create our WaveConfig script and populate it with our data variables.
3. Write public get methods to allow other classes to access our data.

**After watching (learning outcomes)…**
Create a scriptable object for wave data with public methods that return the data values.


### 14 Using A Foreach Loop ###

**In this video (objectives)…**

1. Create a better way to return the path waypoints from our wave config using a list rather than returning the game object.
2. Add a new path and test.

**After watching (learning outcomes)…**
Use A Foreach loop to return a list of waypoint transforms.


### 15 Spawn Multiple Enemies ###

**In this video (objectives)…**

1. Create EnemySpawner.cs to instantiate enemies into our scene.
2. Craft a coroutine that spawns an enemy then waits for time.
3. Use a for loop to continue instantiating enemies until the wave is complete.

**After watching (learning outcomes)…**
Use a coroutine and for loop to spawn a wave of enemies.


### 16 WaveConfig For Path & Speed ###

**In this video (objectives)…**

1. Separate the movement speed and path away from the enemy prefab.
2. Dig deeper into using paramaters on a public method to set our wave config.

**After watching (learning outcomes)…**
Able to feed the wave config information to the enemy path.


### 17 Spawn Multiple Enemy Waves ###

**In this video (objectives)…**

1. Coroutine inception! We place a coroutine within a coroutine.
2. Set up multiple different enemies and multiple different waves, spawning one after another.

**After watching (learning outcomes)…**
Be able to spawn multiple waves one after another.


### 18 Loop All Enemy Waves ###

**In this video (objectives)…**

1. Turn our Start method into a coroutine.
2. Create a looping bool.
3. Create a do while loop that allows us to loop all waves over and over.

**After watching (learning outcomes)…**
Loop all of our enemy waves using a do while loop.


### 19 Create Damage Dealer Class ###



**In this video (objectives)…**



1. Create a class called Damage Dealer that can be placed on whatever game objects we want to use to inflict damage.

2. Create an enemy class that can handle enemy's health.

3. Shoot a laser that harms enemy.



**After watching (learning outcomes)…**

Create a class responsible for dealing damage to objects which have health.


### 20 Destroy Enemy ###



**In this video (objectives)…**



1. Create an if statement to destroy enemy if its health goes below zero.
2. Discuss in more detail the mechanism of creating a method which requires a parameter to be passed into it.



**After watching (learning outcomes)…**

Destroy our enemies when they reach zero health.


### 21 Make Enemy Shoot ###



**In this video (objectives)…**



1. Instantiate laser and provide it velocity in negative y direction.
2. Create new laser prefab for the enemy to shoot.



**After watching (learning outcomes)…**

Make the enemy shoot projectiles at random time intervals.


### 22 Player Life And Death ###



**In this video (objectives)…**



1. Use [Header] attribute to tidy up our variables in the inspector.

2. Make our enemy laser more visible.
3. Add collision, health and death for the player.


**After watching (learning outcomes)…**

Able to destroy the player when its health reaches zero.