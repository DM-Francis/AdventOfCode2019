﻿using Intcode.Instructions;
using System.Collections.Generic;
using Xunit;

namespace Intcode.Tests
{
    public class InputTests
    {
        [Fact]
        public void InputTest()
        {
            // Assemble
            var memory = new List<int> { 3, 2, 0 };
            var inputValue = 10;
            var input = new Input();

            // Act
            input.Execute(memory, 0, inputValue, null);

            // Assert
            var expected = new List<int> { 3, 2, 10 };
            Assert.Equal(expected, memory);
        }

        [Fact]
        public void InputDelegateTest()
        {
            // Assemble
            var memory = new List<int> { 3, 2, 0 };
            static int inputProvider() => 10;
            var input = new Input();

            // Act
            input.Execute(memory, 0, inputProvider, null);

            // Assert
            var expected = new List<int> { 3, 2, 10 };
            Assert.Equal(expected, memory);
        }
    }
}