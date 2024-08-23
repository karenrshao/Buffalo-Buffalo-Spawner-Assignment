Notes:

- I interpreted spawn rate as the probability for one enemy to be picked out of all the available enemies that a spawner can spawn. e.g. 0.5 chance of a red enemy and 0.2 chance of a blue enemy would be split into spawn probabilities of:

    red: 5/7

    blue: 2/7

- I made enemy stats into ints/floats depending on what was implied by the specifications. (Attack is an int, spawn rate and speed are floats, etc.)
- For clarity, enemies are split into different shapes depending on class. Grunts are cubes, archers are spheres, and assassins are cylinders.