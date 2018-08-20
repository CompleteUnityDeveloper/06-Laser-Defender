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