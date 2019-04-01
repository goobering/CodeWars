using System;
using NUnit.Framework;
using Src;

namespace Tests
{
    public class TestKata
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void testXWinOnFirstRow() 
        {
            int[,] board = new int[,] 
            {
                { 1, 1, 1 }, 
                { 0, 2, 2 }, 
                { 0, 0, 0 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testXWinOnSecondRow() 
        {
            int[,] board = new int[,] 
            {
                { 0, 2, 2 }, 
                { 1, 1, 1 }, 
                { 0, 0, 0 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testXWinOnThirdRow() 
        {
            int[,] board = new int[,] 
            {
                { 0, 2, 2 }, 
                { 0, 0, 0 }, 
                { 1, 1, 1 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testXWinOnFirstColumn() 
        {
            int[,] board = new int[,] 
            {
                { 1, 2, 2 }, 
                { 1, 0, 0 }, 
                { 1, 0, 0 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testXWinOnSecondColumn() 
        {
            int[,] board = new int[,] 
            {
                { 2, 1, 2 }, 
                { 0, 1, 0 }, 
                { 0, 1, 0 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testXWinOnThirdColumn() 
        {
            int[,] board = new int[,] 
            {
                { 2, 2, 1 }, 
                { 0, 0, 1 }, 
                { 0, 0, 1 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testXWinOnDownDiagonal() 
        {
            int[,] board = new int[,] 
            {
                { 1, 2, 2 }, 
                { 0, 1, 0 }, 
                { 0, 0, 1 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testXWinOnUpDiagonal() 
        {
            int[,] board = new int[,] 
            {
                { 2, 2, 1 }, 
                { 0, 1, 0 }, 
                { 1, 0, 0 } 
            };
             
            Assert.AreEqual(1, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnFirstRow() 
        {
            int[,] board = new int[,] 
            {
                { 2, 2, 2 }, 
                { 0, 1, 1 }, 
                { 0, 0, 0 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnSecondRow() 
        {
            int[,] board = new int[,] 
            {
                { 0, 1, 1 }, 
                { 2, 2, 2 }, 
                { 0, 0, 0 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnThirdRow() 
        {
            int[,] board = new int[,] 
            {
                { 0, 1, 1 }, 
                { 0, 0, 0 }, 
                { 2, 2, 2 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnFirstColumn() 
        {
            int[,] board = new int[,] 
            {
                { 2, 1, 1 }, 
                { 2, 0, 0 }, 
                { 2, 0, 0 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnSecondColumn() 
        {
            int[,] board = new int[,] 
            {
                { 1, 2, 1 }, 
                { 0, 2, 0 }, 
                { 0, 2, 0 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnThirdColumn() 
        {
            int[,] board = new int[,] 
            {
                { 1, 1, 2 }, 
                { 0, 0, 2 }, 
                { 0, 0, 2 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnDownDiagonal() 
        {
            int[,] board = new int[,] 
            {
                { 2, 1, 1 }, 
                { 0, 2, 0 }, 
                { 0, 0, 2 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testOWinOnUpDiagonal() 
        {
            int[,] board = new int[,] 
            {
                { 1, 1, 2 }, 
                { 0, 2, 0 }, 
                { 2, 0, 0 } 
            };
             
            Assert.AreEqual(2, Kata.IsSolved(board));
        }

        [Test]
        public void testNoPlayBoard() 
        {
            int[,] board = new int[,] 
            {
                { 0, 0, 0 }, 
                { 0, 0, 0 }, 
                { 0, 0, 0 } 
            };
             
            Assert.AreEqual(-1, Kata.IsSolved(board));
        }

        [Test]
        public void testNoWinAfter1TurnBoard() 
        {
            int[,] board = new int[,] 
            {
                { 1, 0, 0 }, 
                { 0, 0, 0 }, 
                { 0, 0, 0 } 
            };
             
            Assert.AreEqual(-1, Kata.IsSolved(board));
        }

        [Test]
        public void testNoWinAfter2TurnBoard() 
        {
            int[,] board = new int[,] 
            {
                { 1, 0, 0 }, 
                { 0, 0, 0 }, 
                { 0, 0, 2 } 
            };
             
            Assert.AreEqual(-1, Kata.IsSolved(board));
        }

        [Test]
        public void testNoWinAfter3TurnBoard() 
        {
            int[,] board = new int[,] 
            {
                { 1, 1, 0 }, 
                { 0, 0, 0 }, 
                { 0, 0, 2 } 
            };
             
            Assert.AreEqual(-1, Kata.IsSolved(board));
        }

        [Test]
        public void testNoWinAfter4TurnBoard() 
        {
            int[,] board = new int[,] 
            {
                { 1, 1, 0 }, 
                { 0, 0, 2 }, 
                { 0, 0, 2 } 
            };
             
            Assert.AreEqual(-1, Kata.IsSolved(board));
        }

        [Test]
        public void testDraw() 
        {
            int[,] board = new int[,] 
            {
                { 2, 1, 2 }, 
                { 2, 1, 1 }, 
                { 1, 2, 1 } 
            };
             
            Assert.AreEqual(0, Kata.IsSolved(board));
        }
    }
}