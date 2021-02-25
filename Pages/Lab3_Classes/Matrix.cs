using System;
namespace OOPGitLabs.Pages.Lab3_Classes
{
    public class Matrix
    {
        public int XLen { get; private set; }
        public int YLen { get; private set; }

        private double[,] _Data;
        public double[,] Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value;
                this.XLen = value.GetLength(0);
                this.YLen = value.GetLength(1);

            }
        }


        public Matrix(double[,] data)
        {
            this.Data = data;
        }

        public Matrix()
        {
        }


        public static Matrix operator +(Matrix first, Matrix sec)
        {
            try
            {
                if ((first.XLen != sec.XLen || first.YLen != sec.YLen))
                {
                    throw new Exception();
                }

                double[,] NewData = new double[first.XLen, first.YLen];

                for (int x = 0; x < first.XLen; x++)
                {
                    for (int y = 0; y < first.YLen; y++)
                    {
                        NewData[x, y] = first.Data[x, y] + sec.Data[x, y];
                    }
                }
                return new Matrix(NewData);
            }
            catch (Exception)
            {
                return new Matrix(new double[1, 1] { { 0 } });
            }
        }

        public static Matrix operator -(Matrix first, Matrix sec)
        {
            try
            {

                if ((first.XLen != sec.XLen || first.YLen != sec.YLen))
                {
                    throw new Exception();
                }

                double[,] NewData = new double[first.XLen, first.YLen];

                for (int x = 0; x < first.XLen; x += 1)
                {
                    for (int y = 0; y < first.YLen; y += 1)
                    {
                        NewData[x, y] = first.Data[x, y] - sec.Data[x, y];
                    }
                }
                return new Matrix(NewData);
            }
            catch (Exception)
            {
                return new Matrix(new double[1, 1] { { 0 } });
            }
        }

        public static Matrix operator *(Matrix first, Matrix sec)
        {
            try
            {
                int NewX = first.XLen;
                int NewY = sec.YLen;

                double[,] NewData = new double[NewX, NewY];

                if (first.YLen != sec.XLen)
                {
                    throw new Exception("Matice se nedaji nasobit");
                }
                for (int x = 0; x < NewX; x += 1)
                {
                    for (int y = 0; y < NewY; y += 1)
                    {
                        NewData[x, y] = 0;
                        for (int k = 0; k < first.YLen; k++)
                        {
                            NewData[x, y] += first.Data[x, k] * sec.Data[k, y];
                        }

                    }
                }
                return new Matrix(NewData);
            }
            catch (Exception)
            {
                return new Matrix(new double[1, 1] { { 0 } });
            }
        }


        public static Boolean operator ==(Matrix first, Matrix sec)
        {

            if ((first.XLen != sec.XLen || first.YLen != sec.YLen))
            {
                return false;
            }

            bool equals = true;
            for (int x = 0; x < first.XLen; x += 1)
            {
                for (int y = 0; y < first.YLen; y += 1)
                {
                    if (first.Data[x, y] != sec.Data[x, y])
                    {
                        equals = false;
                    }
                }
            }
            return equals;
        }

        public static Boolean operator !=(Matrix first, Matrix sec)
        {
            return (first == sec) ? false : true;
        }

        public static Matrix operator -(Matrix first)
        {
            double[,] NewData = new double[first.XLen, first.YLen];

            for (int x = 0; x < first.XLen; x += 1)
            {
                for (int y = 0; y < first.YLen; y += 1)
                {
                    NewData[x, y] = -first.Data[x, y];
                }
            }
            return new Matrix(NewData);
        }

        public double Determinant()
        {
            try
            {
                if (XLen != YLen)
                {
                    throw new Exception("Matice neni ctvercova");
                }

                if (XLen > 3 || XLen == 0)
                {
                    throw new Exception("Matice je prilis velka");
                }
            }
            catch (Exception)
            {
                //Console.WriteLine("Matice nema determinant");
                return 0;
            }

            if (XLen == 1)
            {
                return Data[0, 0];
            }
            else if (XLen == 2)
            {
                return Data[0, 0] * Data[1, 1] - Data[1, 0] * Data[0, 1];
            }
            else return Data[0, 0] * (Data[1, 1] * Data[2, 2] - Data[1, 2] * Data[2, 1]) -
                        Data[0, 1] * (Data[1, 0] * Data[2, 2] - Data[1, 2] * Data[2, 0]) +
                        Data[0, 2] * (Data[1, 0] * Data[2, 1] - Data[1, 1] * Data[2, 0]);
        }

        public override string ToString()
        {
            string output = "<br />";

            for (int i = 0; i < XLen; ++i)
            {
                for (int j = 0; j < YLen; ++j)
                {
                    output += Data[i, j] + "\t";
                }
                output += "<br />";
            }
            return output;
        }
    }
}
