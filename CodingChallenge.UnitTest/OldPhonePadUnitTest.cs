using CodingChallenge.Main.Lib;
using Moq;
namespace CodingChallenge.UnitTest;
public class OldPhonePadUnitTest {
    private readonly Mock<IOldPhonePadConvertor> _mockOldPhonePadConvertor;
    public OldPhonePadUnitTest() {
        _mockOldPhonePadConvertor = new Mock<IOldPhonePadConvertor>();
    }
    [Fact]
    public void ReturnEResultOldPhonePad() {
        // Arrange
        string inputDigits = "33#";
        string expectedResult = "E";
        _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns(expectedResult);
        // Act
        var result = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);
        // Assert
        Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void ReturnBResultOldPhonePad() {
        // Arrange
        string inputDigits = "227*#";
        string expectedResult = "B";
        _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns(expectedResult);
        // Act
        var result = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);
        // Assert
        Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void ReturnHELLOResultOldPhonePad() {
        // Arrange
        string inputDigits = "4433555 555666#";
        string expectedResult = "HELLO";
        _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns(expectedResult);
        // Act
        var actualResult = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
    [Fact]
    public void ReturnTURINGResultOldPhonePad() {
        // Arrange
        string inputDigits = "8 88777444666*664#";
        string expectedResult = "TURING";
        _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns(expectedResult);
        // Act
        var actualResult = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
    [Fact]
    public void ReturnHELLOWORLDResultOldPhonePad() {
        // Arrange
        string inputDigits = "4433555 555666 96667775553";
        string expectedResult = "HELLOWORLD";
        _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns(expectedResult);
        // Act
        var actualResult = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
    [Fact]
    public void ReturnNotTrueResultOldPhonePad() {
        // Arrange
        string inputDigits = "222 2 22";
        string expectedResult = "C";
        _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns("CAB");
        // Act
        var actualResult = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);
        // Assert
        Assert.NotEqual(expectedResult, actualResult);
    }
    [Fact]
    public void ReturnCABResultOldPhonePad() {
        // Arrange
        string inputDigits = "222 2 22";
        string expectedResult = "CAB";
        _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns(expectedResult);
        // Act
        var actualResult = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
    [Fact]
    public void ReturnCorrectedResultGenerateWords() {
        // Arrange
        string input = "2 2 2";
        string expectedResult = "aaa";
        _mockOldPhonePadConvertor.Setup(x => x.GenerateWords(input)).Returns(expectedResult);
        // Act
        var actualResult = _mockOldPhonePadConvertor.Object.GenerateWords(input);
        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
