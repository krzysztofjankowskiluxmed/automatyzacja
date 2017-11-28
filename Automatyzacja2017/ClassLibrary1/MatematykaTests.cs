using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class MatematykaTests
    {
        [Theory]
        [InlineData(10, 20, 30 )]
        [InlineData(50, 20, 70)]
       

        public void Method_add_returns_sum_of_given_values(double x, double y, double expected)
        {
            // arrange
            Matematyka math = new Matematyka();
            //var math = new Matematyka(); ---- mozliwy taki zapis 

            //act
            double result = math.Add(x, y);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Method_add_returns_sum2_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();
            //var math = new Matematyka(); ---- mozliwy taki zapis 

            //act
            double result = math.Add(40, -20);

            //assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Method_add_returns_sumb_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka(); 

            //act
            double result = math.Substract(10, 20);

            //assert
            Assert.Equal(-10, result);
        }

        [Fact]
        public void Method_add_returns_sumb2_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            //act
            double result = math.Substract(80, 20);

            //assert
            Assert.Equal(60, result);
        }

        [Fact]
        public void Method_add_returns_Multiply_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            //act
            double result = math.Multiply(10, 20);

            //assert
            Assert.Equal(200, result);
        }

        [Fact]
        public void Method_add_returns_Multiply2_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            //act
            double result = math.Multiply(-10, -20);

            //assert
            Assert.Equal(200, result);
        }

        [Fact]
        public void Method_add_returns_Divide_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            //act
            double result = math.Divide(20, 20);

            //assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Method_add_returns_Divide2_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            //act
            double result = math.Divide(10, 20);

            //assert
            Assert.Equal(0.5, result);
            //Assert.Throws<DivideByZeroException>(() => math.Add (25,0));
        }
    }
}
