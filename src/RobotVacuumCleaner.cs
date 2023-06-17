using System;
using System.IO;
namespace RobotVacuumCleaner;

public class RobotVacuumCleaner
{
    private Robot _firstRobot;
    private Robot _secondRobot;

    public RobotVacuumCleaner(Position firstRobotPosition, string firstRobotInstructions, Position secondRobotPosition, string secondRobotInstructions)
    {
        _firstRobot = new Robot(firstRobotPosition);
        _secondRobot = new Robot(secondRobotPosition);

        _firstRobot.Move(firstRobotInstructions);
        _secondRobot.Move(secondRobotInstructions);
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