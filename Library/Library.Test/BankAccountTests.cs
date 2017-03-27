using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Models;

namespace Library.Test
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void TestNewAccount()
        {
            // Assemble
            decimal expected = 0m;
            var result = new BankAccount(123, 123);

            // Act

            // Assert
            Assert.AreEqual(expected, result.Balance);
        }

        [TestMethod]
        public void TestNegativeTransaction()
        {
            // Assemble
            decimal expected = -10m;
            var result = new BankAccount(123, 123);

            // Act
            result.AddTransaction(new Transaction(-10m, ""));

            // Assert
            Assert.AreEqual(expected, result.Balance);
        }

        [TestMethod]
        public void TestPositiveTransaction()
        {
            // Assemble
            decimal expected = 10m;
            var result = new BankAccount(123, 123);

            // Act
            result.AddTransaction(new Transaction(10m, ""));

            // Assert
            Assert.AreEqual(expected, result.Balance);
        }

        [TestMethod]
        public void TestMultiplePositiveTransaction()
        {
            // Assemble
            decimal expected = 725m;
            var result = new BankAccount(123, 123);

            // Act
            result.AddTransaction(new Transaction(10m, ""));
            result.AddTransaction(new Transaction(100m, ""));
            result.AddTransaction(new Transaction(25m, ""));
            result.AddTransaction(new Transaction(590m, ""));

            // Assert
            Assert.AreEqual(expected, result.Balance);
        }

        [TestMethod]
        public void TestMultipleNegativeTransaction()
        {
            // Assemble
            decimal expected = -725m;
            var result = new BankAccount(123, 123);

            // Act
            result.AddTransaction(new Transaction(-10m, ""));
            result.AddTransaction(new Transaction(-100m, ""));
            result.AddTransaction(new Transaction(-25m, ""));
            result.AddTransaction(new Transaction(-590m, ""));

            // Assert
            Assert.AreEqual(result.Balance, expected);
        }

        [TestMethod]
        public void TestMultipleMixedTransaction()
        {
            // Assemble
            decimal expected = 48m;
            var result = new BankAccount(123, 123);

            // Act
            result.AddTransaction(new Transaction(10m, ""));
            result.AddTransaction(new Transaction(24m, ""));
            result.AddTransaction(new Transaction(-52m, ""));
            result.AddTransaction(new Transaction(25m, ""));
            result.AddTransaction(new Transaction(-10m, ""));
            result.AddTransaction(new Transaction(24m, ""));
            result.AddTransaction(new Transaction(52m, ""));
            result.AddTransaction(new Transaction(-25m, ""));

            // Assert
            Assert.AreEqual(expected, result.Balance);
        }
    }
}
