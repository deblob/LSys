using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSys
{
    public class TurtleSystem
    {
        private class turtleInstruction
        {
            public enum InstructionTypeEnum
            {
                Move,
                TurnLeft,
                TurnRight,
                SavePosition,
                ReturnPosition,
                ResetAngle
            }

            public InstructionTypeEnum InstructionType;
            public float Data;

            public turtleInstruction(InstructionTypeEnum instructionType, float data = -1f)
            {
                InstructionType = instructionType;
                Data = data;
            }
        }

        private Size _worldSize;
        private PointF _turtlePosition;
        private float _turtleAngle = 0;
        private Queue<turtleInstruction> _instructionStack = new Queue<turtleInstruction>();
        private Stack<Tuple<PointF, float>> _positionStack = new Stack<Tuple<PointF, float>>();

        public TurtleSystem(Size worldSize, float startPosX = -1, float startPosY = -1)
        {
            _worldSize = worldSize;
            if (startPosX == -1 && startPosY == -1)
                _turtlePosition = new PointF(_worldSize.Width / 2f, _worldSize.Height / 2f);
            else
                _turtlePosition = new PointF(startPosX, startPosY);
        }

        public void Move(int length)
        {
            _instructionStack.Enqueue(new turtleInstruction(turtleInstruction.InstructionTypeEnum.Move, length));
        }

        public void TurnLeft(float angle)
        {
            _instructionStack.Enqueue(new turtleInstruction(turtleInstruction.InstructionTypeEnum.TurnLeft, angle));
        }

        public void TurnRight(float angle)
        {
            _instructionStack.Enqueue(new turtleInstruction(turtleInstruction.InstructionTypeEnum.TurnRight, angle));
        }

        public void SavePosition()
        {
            _instructionStack.Enqueue(new turtleInstruction(turtleInstruction.InstructionTypeEnum.SavePosition));
        }

        public void ReturnToPosition()
        {
            _instructionStack.Enqueue(new turtleInstruction(turtleInstruction.InstructionTypeEnum.ReturnPosition));
        }

        public void ResetAngle()
        {
            _instructionStack.Enqueue(new turtleInstruction(turtleInstruction.InstructionTypeEnum.ResetAngle));
        }

        public Bitmap Render()
        {
            Bitmap result = new Bitmap(_worldSize.Width, _worldSize.Height);
            Pen linePen = new Pen(new SolidBrush(Color.Black));

            using (Graphics g = Graphics.FromImage(result))
            {
                int count = _instructionStack.Count;
                for (int i = 0; i < count; ++i)
                {
                    var inst = _instructionStack.Dequeue();

                    switch (inst.InstructionType)
                    {
                        case turtleInstruction.InstructionTypeEnum.Move:
                            float x = _turtlePosition.X + inst.Data * (float)Math.Cos(degreesToRadians(_turtleAngle) - degreesToRadians(90));
                            float y = _turtlePosition.Y + inst.Data * (float)Math.Sin(degreesToRadians(_turtleAngle) - degreesToRadians(90));
                            PointF newPos = new PointF(x, y);


                            g.DrawLine(linePen, _turtlePosition, newPos);
                            _turtlePosition = newPos;
                            break;

                        case turtleInstruction.InstructionTypeEnum.TurnLeft:
                            if (_turtleAngle - inst.Data < 0)
                                _turtleAngle = 360 - (inst.Data - _turtleAngle);
                            else
                                _turtleAngle -= inst.Data;
                            break;

                        case turtleInstruction.InstructionTypeEnum.TurnRight:
                            if (_turtleAngle + inst.Data > 360)
                                _turtleAngle = inst.Data - (360 - _turtleAngle);
                            else
                                _turtleAngle += inst.Data;
                            break;

                        case turtleInstruction.InstructionTypeEnum.SavePosition:
                            _positionStack.Push(Tuple.Create(_turtlePosition, _turtleAngle));
                            break;

                        case turtleInstruction.InstructionTypeEnum.ReturnPosition:
                            var old = _positionStack.Pop();
                            _turtlePosition = old.Item1;
                            _turtleAngle = old.Item2;
                            break;

                        case turtleInstruction.InstructionTypeEnum.ResetAngle:
                            _turtleAngle = 0;
                            break;
                    }
                }

                g.Flush();
            }

            return result;
        }

        private float degreesToRadians(float angle)
        {
            return (float)(Math.PI * angle / 180.0);
        }
    }
}
