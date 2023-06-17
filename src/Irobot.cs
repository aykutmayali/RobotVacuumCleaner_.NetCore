using System;
using System.IO;
namespace RobotVacuumCleaner;

public interface IRobot
{
    void Move(string instructions);
}