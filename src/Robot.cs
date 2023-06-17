using System;
using System.IO;
namespace RobotVacuumCleaner;

public class Robot : IRobot
{
    private Position _position;

    public Robot(Position position)
    {
        _position = position;
    }

    public void Move(string instructions)
    {
        foreach (var instruction in instructions)
        {
            if (instruction == 'L')
                TurnLeft();
            else if (instruction == 'R')
                TurnRight();
            else if (instruction == 'M')
                MoveForward();
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

    private void MoveForward()
    {
        switch (_position.Orientation)
        {
            case Orientation.N:
                _position.Y++;
                break;
            case Orientation.E:
                _position.X++;
                break;
            case Orientation.S:
                _position.Y--;
                break;
            case Orientation.W:
                _position.X--;
                break;
        }
    }

    public Position GetPosition()
    {
        return _position;
    }
}