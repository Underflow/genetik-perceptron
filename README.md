Description
===========

This is an empiricist project to learn about ann and ga. I've never worked with neural networks and this is a first try.

The goal of this project is to implement a neural network which could be trained by a genetic algorithm (with a sufficient abstraction level to be usable to solve many kind of problems).

I will probably reuse it to make a version using backpropagation as learning algorithm.

What is already done
====================

* Implementation of neural networks
* DNA translation to build neural networks from a genetic code (double array)

What will be done
=================

* Neural network training with a GA
    * Mutations
    * Crossovers
    * Selection
* TCP interface for fitness evaluation

Applications
============

This project could be use to train neural networks to solve easy problems as :

* Learn to play Pong, Tetris or (may be) Mario
* Drive a vehicle and avoid obstacles
* Train a population to evolve in an environment (with food and enemies for example)
