using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtelierAuto.Models;
using AtelierAuto.Commands;
using AtelierAuto.Controllers;
using AtelierAuto.Evenimente;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;

namespace AtelierTest
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IComandaSource> _externalMock;

        [TestMethod]
        public void TestMethod1()
        {
            _externalMock = new Mock<IComandaSource>();
            _externalMock.Setup(m => m.CalculCostComanda()).Returns(1230.4);
        }  
        
        [Fact]
        public void Cost()
        {
            //arrange
            double a = 1230.4;
            Comanda comanda = new Comanda();
            _externalMock
                .Setup(m => m.CalculCostComanda())
                .Returns(a);

            var classTested = comanda;


            //act 
            double valueReturne = comanda.CalculCostComanda();
            //assert
            Xunit.Assert.Equal(1230.4, valueReturne);
        }
    }

}