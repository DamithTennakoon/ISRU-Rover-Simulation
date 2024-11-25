# ISRU-Rover-Simulation
## Scenes
A scene in Unity represents various 3D environments in Unity. For this project, there are 2 mains scenes. The **main** scene, that can be used for testing the rover, is found in `Assets/Scenes/Sample Scene`. The lunar terrain scene can be found in `Lunar Landscape 3D/Scenes/Lunar Landscape 3D`. 

## Scripts
All the scripts are located in the `Assets/Scripts` folder. Currently, there are three main scripts.

1. `wheel_mechanics.cs`: Responsbile for referencing the 'wheel collider' objects in the 'Leo_Rover_UV (1)' hierarchy. Also sets accelerations and turn angles to each of the wheels.
2. `keyboard_controller.cs`: Takes keyboard inputs, when the application is running, to move the rover. Currently uses the 'WASD' keys for rover control.
3. `lidar_sensor.cs`: Simulates a single-ray lidar sensor, using Unit's `Raycast` method. This script it still in development and may not be too crucial for out simulation!

