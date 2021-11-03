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
   class MOperations
    {
       
        public Matrix<double> Matrixadding(Matrix<double> A, Matrix<double> B) 
        {
            
            Matrix<double> C = A + B;

            return C;

        }
        public Matrix<double> Matrixminus(Matrix<double> A, Matrix<double> B) 
        {
            Matrix<double> C = A - B;

            return C;

        }
        public Matrix<double> Matrixmultiply(Matrix<double> A, Matrix<double> B) 
        {
            Matrix<double> C = A * B;

            return C;

        }

        public Matrix<double> Matrixtranspose(Matrix<double> A) 
        {
            Matrix<double> C = A.Transpose();

            return C;

        }


    }
    
}
