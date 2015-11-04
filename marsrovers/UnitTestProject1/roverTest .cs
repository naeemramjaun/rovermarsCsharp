using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using marsrovers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //NORMAL TEST FOR SETTERS AND GETTERS  FOR ROVERS  
        [TestMethod]
        public void testSetcoodX()
        {
                //Arrange 
                rover rover = new rover(); 
                //Act 
                rover.setcoodX(10);
                //Assert
                Assert.IsTrue(rover.getcoodX() == 10);
        }

        [TestMethod]
        public void testSetcoodY()
        {
            //Arrange
            rover rover = new rover();
            //Act
            rover.setcoodY(20);
            //Assert
            Assert.IsTrue(rover.getcoodY() == 20);
        }
         
        [TestMethod]
        public void testGetcoodX()
        {
            //Arrange
            rover rover = new rover();
            //Act
            int output = rover.getcoodX();
            //Assert
            Assert.AreEqual(output, 0);
        }

         [TestMethod]
        public void testGetcoodY()
        {
            //Arrange
            rover rover = new rover();
            //Act
            int output = rover.getcoodY();
            //Assert
            Assert.AreEqual(output, 0);
        }

        [TestMethod]
         public void testSetposition()
         {
             //Arrange
             rover rover = new rover();
             //Act
             rover.setposition("N");
             //Assert
             Assert.IsTrue(rover.getposition() == "N");
         }
        [TestMethod]
        public void testGetposition()
        {
            //Arrange
            rover rover = new rover();
            //Act
            rover.getposition();
            //Assert
            Assert.AreEqual(rover.getposition(), null);
        }


        //ABNORMAL TEST FOR SETTERS GETTERS OF ROVERS 
        [TestMethod]
        public void testSetcoodXAbnormal()
        {
            //Arrange 
            rover rover = new rover();
            //Act 
            rover.setcoodX(999999999);
            //Assert
            Assert.IsTrue(rover.getcoodX() == 999999999);
        }

             [TestMethod]
                [ExpectedException(typeof(FormatException)) ]
                public void testSetcoodXAbnormalString (){
                 //Arrange 
                 rover rover = new rover () ; 
                 //Act 
                 int a =int.Parse("abc") ;
                 rover.setcoodX(a);
                 //Assert
                 Assert.IsTrue( rover.getcoodX()== a);
         }


         [TestMethod]
         [ExpectedException(typeof(FormatException))]
             public void testSetcoodXAbnormalSymbol()
             {
                 //Arrange
                 rover rover = new rover();
                 //Act 
                 int a = int.Parse("#%$^&^%$^%");
                 rover.setcoodX(a);
                 //Assert
                 Assert.IsTrue(rover.getcoodX() == a);
             }
       
        
        [TestMethod]
         [ExpectedException(typeof(FormatException))]
         public void testSetcoodXAbnormalIsNull()
         {
             //Arrange
             rover rover = new rover();
             //Act 
             int a = int.Parse("");
             rover.setcoodX(a);
             //Assert
             Assert.IsTrue(rover.getcoodX().Equals(a));

         }


        [TestMethod]
        public void CreateRover()
        {
            //Arrange 
            rover rover = new rover();
            //Assert
            Assert.IsNotNull(rover);
        }

    }
}
