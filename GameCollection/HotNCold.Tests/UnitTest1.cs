using System;
using HotNCold;
namespace HotNCold.Tests;


// Arrange - Setup, what needs to exist for the test to work
// Act - What behavior is being checked?
// Assert - What are the expected results (positive and negative)
// Test Name Convention
// unitOfTest_TestCondition_CorrectBehavior

public class UnitTest1 {
    [Fact]
    public void PrintResult_Correct_Congratulate() {

        // Arrange
        Guessing tmp = new Guessing();
        int secret = 5;
        int user = 5;
        string expected = "Congratulations, you've guessed the secret number!";

        // Act
        string result = tmp.PrintResult(secret, user);

        // Assert
        Assert.Equal(expected: expected, actual: result);

    }

    [Fact]
    public void PrintResult_TooHigh_TellTooHigh() {
        // Arrange
        Guessing tmp = new Guessing();
        int secret = 5;
        int user = 6;
        string expected = "Oops, too high!";

        // Act
        string result = tmp.PrintResult(secret, user);

        // Assert
        Assert.Equal(expected: expected, actual: result);
    }
}