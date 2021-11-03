using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Windows.Forms;

namespace MatrixCaculator
{
 
        interface Imatrix
        {
            Matrix<double> createMatrix(TextBox textBox);
        }

        class ConcreteMatrixA : Imatrix
        {
            public Matrix<double> createMatrix(TextBox textBox)
            {

                string[] matrixA_rows = textBox.Text.Split(
                      new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                int Anum_rows = matrixA_rows.Length;
                string[] matrixA_colums = textBox.Lines[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int Anum_colums = matrixA_colums.Length;

                Matrix<double> matrix = DenseMatrix.OfArray(new double[Anum_rows, Anum_colums]);
                bool comparecolmsN = true;

                for (int i = 0; i < Anum_rows; i++)
                {
                    if (!(textBox.Lines[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length == textBox.Lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length))
                    {
                        comparecolmsN = false;
                    }

                }

                if (comparecolmsN == true)
                {

                    try
                    {
                        for (int row = 0; row < Anum_rows; row++)
                        {
                            char[] chars = { ' ' };
                            string[] row_items =
                                matrixA_rows[row].Split(chars, StringSplitOptions.RemoveEmptyEntries);

                            for (int col = 0; col < Anum_colums; col++)
                            {


                                matrix[row, col] = double.Parse(row_items[col]);

                            }

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Please check if there is a non-numeric value in the matrix A.", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }


                }

                else
                {
                    MessageBox.Show("The number of columns in each matrix A's row is incorrect!", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return matrix;

            }



        }

        class ConcreteMatrixB : Imatrix
        {

            public Matrix<double> createMatrix(TextBox textBox)
            {
          
            

                string[] matrixA_rows = textBox.Text.Split(
                      new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                int Anum_rows = matrixA_rows.Length;
                string[] matrixA_colums = textBox.Lines[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int Anum_colums = matrixA_colums.Length;

                Matrix<double> matrix = DenseMatrix.OfArray(new double[Anum_rows, Anum_colums]);
                bool comparecolmsN = true;

                for (int i = 0; i < Anum_rows; i++)
                {
                    if (!(textBox.Lines[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length == textBox.Lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length))
                    {
                        comparecolmsN = false;
                    }

                }

                if (comparecolmsN == true)
                {

                    try
                    {
                        for (int row = 0; row < Anum_rows; row++)
                        {
                            char[] chars = { ' ' };
                            string[] row_items =
                                matrixA_rows[row].Split(chars, StringSplitOptions.RemoveEmptyEntries);

                            for (int col = 0; col < Anum_colums; col++)
                            {


                                matrix[row, col] = double.Parse(row_items[col]);

                            }

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Please check if there is a non-numeric value in the matrix B.", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }


                }

                else
                {
                    MessageBox.Show("The number of columns in each matrix B's row is incorrect!", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return matrix;

            }
        }

        

        abstract class Creator
        {
            public abstract Imatrix GetMatrixSide(TextBox textBox);
        }

        class ConcreteCreator : Creator
        {
            public override Imatrix GetMatrixSide(TextBox textBox)
            {
               string textboxname = Convert.ToString(textBox.Name);


                switch (textboxname)
                {
                    case "textBox1" : return new ConcreteMatrixA();
                    case "textBox2" : return new ConcreteMatrixB();
                    default: throw new ArgumentException("Invalid type", "type");
                }
            }
        }



}