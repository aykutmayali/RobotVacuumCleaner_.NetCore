using System;
using System.IO;
namespace RobotVacuumCleaner;

public class Robot : IRobot
{
    private Position _position;

    public Robot(Position position, int roomWidth, int roomHeight)
    {
        _position = position;
    }

    public void Move(string instructions, int roomWidth, int roomHeight)
    {
        foreach (var instruction in instructions)
        {
            if (instruction == 'L')
                TurnLeft();
            else if (instruction == 'R')
                TurnRight();
            else if (instruction == 'M')
                MoveForward(roomWidth, roomHeight);
            else
                throw new ArgumentException($"Invalid instruction: {instruction}");
        }
    }

    private void TurnLeft()
    {
        switch (_position.Orientation)
        {
            case Orientation.N:
                _position.Orientation = Orientation.W;
                break;
            case Orientation.E:
                _position.Orientation = Orientation.N;
                break;
            case Orientation.S:
                _position.Orientation = Orientation.E;
                break;
            case Orientation.W:
                _position.Orientation = Orientation.S;
                break;
        }
    }

    private void TurnRight()
    {
        switch (_position.Orientation)
        {
            case Orientation.N:
                _position.Orientation = Orientation.E;
                break;
            case Orientation.E:
                _position.Orientation = Orientation.S;
                break;
            case Orientation.S:
                _position.Orientation = Orientation.W;
                break;
            case Orientation.W:
                _position.Orientation = Orientation.N;
                break;
        }
    }

    private void MoveForward(int roomWidth, int roomHeight)
    {
        switch (_position.Orientation)
        {
            case Orientation.N:
                if (_position.Y + 1 > roomHeight)
                    throw new InvalidOperationException("Cannot move north. The room size is not big enough.");
                _position.Y++;
                break;
            case Orientation.E:
                if (_position.X + 1 > roomWidth)
                    throw new InvalidOperationException("Cannot move east. The room size is not big enough.");
                _position.X++;
                break;
            case Orientation.S:
                if (_position.Y - 1 < 0)
                    throw new InvalidOperationException("Cannot move south. The room size is not big enough.");
                _position.Y--;
                break;
            case Orientation.W:
                if (_position.X - 1 < 0)
                    throw new InvalidOperationException("Cannot move west. The room size is not big enough.");
                _position.X--;
                break;
        }
    }

    public Position GetPosition()
    {
        return _position;
    }
}