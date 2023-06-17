"# RobotVacuumCleaner\_.NetCore"

## Back-End Developer – Case Study

### General Criteria:

• - Application needs to be developed in .Net Core.
• - Unit test should be written for application.
• - SOLID principles should be followed.
• - Codes need to be added to a Github repository. A read permission need to be given to
Gizil. (github.com/Gizil-Digital)
Code Review: Robot Vacuum Cleaner
A company is developing two new robot vacuum cleaners to navigate a rectangular room. The
robots are equipped with sensors that allow them to detect the edges of the room and obstacles
within it. The robots' position and orientation are represented by a combination of x and y
coordinates and a letter representing one of the four cardinal compass points. The room is
divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means
the robot is in the bottom left corner of the room and facing North. In order to control the robot,
the user sends a simple string of letters. The possible letters are 'L', 'R', and 'M'. 'L' and 'R' make
the robot turn 90 degrees left or right respectively, without moving from its current spot. 'M'
means move forward one grid point in the current orientation. Assume that the square directly
North from (x, y) is (x, y+1).

#### Input:

The first line of input is the size of the room, represented by two integers separated by a space,
which correspond to the width and height of the room. The second line of input is the position
and orientation of the first robot, represented by two integers and a letter separated by spaces,
which correspond to the x and y coordinates and the robot's orientation. The third line of input
is a string of instructions telling the first robot how to navigate the room. The fourth line of input
is the position and orientation of the second robot, represented by two integers and a letter
separated by spaces, which correspond to the x and y co-ordinates and the robot's orientation.
The fifth line of input is a string of instructions telling the second robot how to navigate the room.
The orientation is represented by a single letter ('N', 'E', 'S', or 'W'). The rest of the input is a string
of instructions telling the robot how to navigate the room.

#### Output:

The output should be the final position and orientation of both robots after they have completed
navigating the room.

#### Test Input:

5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM

#### Expected Output:

1 3 N
5 1 E

#### Note: In this scenario, the robot vacuum cleaner starts at the initial position and orientation

specified in the input. The 'L', 'R', and 'M' instructions indicate the robot should turn left or right
by 90 degrees or move forward one grid point in the current orientation, respectively. Each robot
will be finished sequentially, which means that the second robot won't start to move until the
first one has finished moving. The robot will execute the instructions in sequence until it has
completed navigating the room. Robots cannot move out of the grid area. The output should be
the final position and orientation of the robot after it has completed navigating the room.
