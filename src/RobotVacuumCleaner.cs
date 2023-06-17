using System;
using System.IO;
namespace RobotVacuumCleaner;

public class RobotVacuumCleaner
{
    private Robot _firstRobot;
    private Robot _secondRobot;

    public RobotVacuumCleaner(Position firstRobotPosition, string firstRobotInstructions, Position secondRobotPosition, string secondRobotInstructions, int roomWidth, int roomHeight)
    {
        _firstRobot = new Robot(firstRobotPosition, roomWidth, roomHeight);
        _secondRobot = new Robot(secondRobotPosition, roomWidth, roomHeight);

        _firstRobot.Move(firstRobotInstructions, roomWidth, roomHeight);
        _secondRobot.Move(secondRobotInstructions, roomWidth, roomHeight);
    }

    public Position GetFirstRobotPosition()
    {
        return _firstRobot.GetPosition();
    }

    public Position GetSecondRobotPosition()
    {
        return _secondRobot.GetPosition();
    }
}