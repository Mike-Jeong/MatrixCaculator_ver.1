using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double; 

namespace MatrixCaculator
{
   
    public partial class Form1 : Form
    {
        MOperations m = new MOperations();

        Creator mc = new ConcreteCreator();

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please input the elements of Matrix A", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Please input the elements of Matrix B", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Imatrix Matrixx = mc.GetMatrixSide(textBox1);
                    Imatrix Matrixxx = mc.GetMatrixSide(textBox2);

                    Matrix<double> matrixA = Matrixx.createMatrix(textBox1);
                    Matrix<double> matrixB = Matrixxx.createMatrix(textBox2);

                    if (textBox1.Text.StartsWith(Convert.ToString(matrixA[0,0])) && textBox2.Text.StartsWith(Convert.ToString(matrixB[0, 0])))
                    {
                        try
                        {
                            Matrix<double> mResult = m.Matrixadding(matrixA, matrixB);

                            textBox3.Text = Convert.ToString(mResult);
                            textBox3.Select(0, textBox3.Lines[0].Length + 2);
                            textBox3.Cut();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Please check A and B matrices  have the same number of rows and columns.", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                                     
                }
                
             

            }



          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
            button4.Enabled = true;

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please input the elements of Matrix A", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Please input the elements of Matrix B", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    Imatrix Matrixx = mc.GetMatrixSide(textBox1);
                    Imatrix Matrixxx = mc.GetMatrixSide(textBox1);

                    Matrix<double> matrixA = Matrixx.createMatrix(textBox1);
                    Matrix<double> matrixB = Matrixxx.createMatrix(textBox2);

                    if (textBox1.Text.StartsWith(Convert.ToString(matrixA[0, 0])) && textBox2.Text.StartsWith(Convert.ToString(matrixB[0, 0])))
                    {
                        try
                        {
                            Matrix<double> mResult = m.Matrixminus(matrixA, matrixB);

                            textBox3.Text = Convert.ToString(mResult);
                            textBox3.Select(0, textBox3.Lines[0].Length + 2);
                            textBox3.Cut();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Please check A and B matrices  have the same number of rows and columns.", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        
                    }
                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please input the elements of Matrix A", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                double B;

                if (!string.IsNullOrEmpty(textBox2.Text) && double.TryParse(textBox2.Text, out B))
                {


                    Matrix<double> matrixA;                    
                    Matrix<double> mResult;

                    Imatrix Matrixx = mc.GetMatrixSide(textBox1);
                    matrixA = Matrixx.createMatrix(textBox1);

                    if (textBox1.Text.StartsWith(Convert.ToString(matrixA[0, 0])))
                    {
                        mResult = matrixA * B;

                        textBox3.Text = Convert.ToString(mResult);
                        textBox3.Select(0, textBox3.Lines[0].Length + 2);
                        textBox3.Cut();
                    }

                
                }

                else if (!string.IsNullOrEmpty(textBox2.Text))
                {
             
                    Imatrix Matrixx = mc.GetMatrixSide(textBox1);
                    Imatrix Matrixxx = mc.GetMatrixSide(textBox2);

                    Matrix<double> matrixA = Matrixx.createMatrix(textBox1);
                    Matrix<double> matrixB = Matrixxx.createMatrix(textBox2);

                    if (textBox1.Text.StartsWith(Convert.ToString(matrixA[0, 0])) && textBox2.Text.StartsWith(Convert.ToString(matrixB[0, 0])))
                    {
                        try
                        {
                            Matrix<double> mResult = m.Matrixmultiply(matrixA, matrixB);

                            textBox3.Text = Convert.ToString(mResult);
                            textBox3.Select(0, textBox3.Lines[0].Length + 2);
                            textBox3.Cut();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Please check the number of columns in matrix A and number of rows in matrix B are the same.", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                     MessageBox.Show("Please input the elements of Matrix B", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   

                }

                                                 
            }



        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please input the elements of Matrix A", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Imatrix Matrixx = mc.GetMatrixSide(textBox1);
            
                Matrix<double> matrixA = Matrixx.createMatrix(textBox1);
                    

                if (textBox1.Text.StartsWith(Convert.ToString(matrixA[0, 0])))
                {
                    Matrix<double> mResult = m.Matrixtranspose(matrixA);

                    textBox3.Text = Convert.ToString(mResult);
                    textBox3.Select(0, textBox3.Lines[0].Length + 2);
                    textBox3.Cut();
                }



            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBox1.ReadOnly == true)
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;                
                textBox1.ReadOnly = false;
            }
            if (textBox1.Text.StartsWith(" "))
            {
                string txt1 = textBox1.Text.Trim();
                textBox1.Text = txt1;
            }

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {


            if (textBox2.Text.StartsWith(" "))
            {
                string txt2 = textBox2.Text.Trim();
                textBox2.Text = txt2;
            }

            if (textBox1.ReadOnly == false && textBox2.ReadOnly == true)
            {
                textBox2.ReadOnly = false;
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }

           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
