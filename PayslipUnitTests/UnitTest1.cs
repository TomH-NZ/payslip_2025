namespace PayslipUnitTests;

public class UnitTest1
{
    [Fact]
    public void GivenTwoNumbers_WhenAddingThemTogether_ThenTheCorrectResultReturned()
    {
        //Arrange
        var calc = new payslip_2025.TestCalc();
        
        //Act
        var result = calc.TestCalculator(1, 2);
        
        //Assert
        Assert.Equal(3, result);
    }
}
//Unit test written to verify that the test project is correctly set up and can reference the payslip_2025 project.