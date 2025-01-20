# Program analysis,design,implement,unit test(s) and functional test(s) for OldPhoneKeypad type process
- An old phone keypad with alphabetical letters,a backspace key,and a send button to show the data to the UI.
- Charactor mapping process  from inputted digit(s) to the defined english alphabet .
# Functional requriement(s) 
- Here is an old phone keypad with alphabetical letters, a backspace key, and a send button.
- Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.
- For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’.
- You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.
# Prompt:
- Screen design of Old Phone KeyPad UI Simple
- Assume that a send “#” will always be included at the end of every input.
 ![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/36dcdeb4-7f2a-429f-a23e-185279db5a14)

# Code Implementation  
## Method 1 **OldPhonePad(string input)**
- This method do the mapping process from the inputed (digital numbers)  to string (english alphabet)
```
public string OldPhonePad(string input)
{
    input = input.Replace("#", "");
    string? results = null;

    if (string.IsNullOrEmpty(input))
    {
        return results;
    }
    //generate words according to input digits.
    results = GenerateWords(input);
    return results.ToUpper();
}
```
- https://github.com/mrkyaing/SE-CodingChallenge/blob/main/CodingChallenge.Main/Lib/IOldPhonePadConvertor.cs
## Method 2 **GenerateWords(string digits)**
- This method is encapsuleted and generate the alphabest from digits according to keypad dictionary value(s). 
```
private static string GenerateWords(string digits){
//DO WORD GENERATE PROCESS 
}
```
- https://github.com/mrkyaing/SE-CodingChallenge/blob/main/CodingChallenge.Main/Lib/IOldPhonePadConvertor.cs
# Examples output(s):
- OldPhonePad(“33#”) => output: E
- OldPhonePad(“227*#”) => output: B
- OldPhonePad(“4433555 555666#”) => output: HELLO
- OldPhonePad(“8 88777444666*664#”) => output:TURING
- OldPhonePad(“888 85632*361*#”) => output:VTJMDDM
# Output screen Result(s)
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/e29eeea5-bcba-4dad-bbdb-cf9374046ad3)

# Unit Test Result by using xUnit & Moq LIB
- xUnit Test used for unit testing for generate digit(s) to english alphabet .
```
[Fact]
public void ReturnEResultOldPhonePad()
{
    // Arrange
    string inputDigits = "33#";
    string expectedResult = "E";
    _mockOldPhonePadConvertor.Setup(x => x.OldPhonePad(inputDigits)).Returns(expectedResult);

    // Act
    var result = _mockOldPhonePadConvertor.Object.OldPhonePad(inputDigits);

    // Assert
    Assert.Equal(expectedResult, result);
}
```
- https://github.com/mrkyaing/SE-CodingChallenge/blob/main/CodingChallenge.UnitTest/OldPhonePadUnitTest.cs
  ![image](https://github.com/user-attachments/assets/01ac2d9c-4874-4b4f-aa8f-02b31f4c1f3d)

# Software Requirement
- Framework :.Net Core 8.0
- Tools     :Visual Studio 2022 IDE or Visual Studio Code
- Language  : C#
- Main Program Run
![image](https://github.com/user-attachments/assets/e006b977-87ef-4543-be64-dac2f9b572d0)
- Unit Test Project run
![image](https://github.com/user-attachments/assets/43b2b648-0a57-482d-bcf5-8875f99a1a8a)
# How to Get Started with the OldPhonePad encoding from digits to english alphabet  as C# Library 
- If you can use this OldPhonePad(string input) in your project,you can reference this DLL(Dynamic Link Library) file in your project .
![dll](https://github.com/user-attachments/assets/12a95342-f433-4584-b798-4e0e9dad1efa)

- And then by invoking  this static method EncodingUtility.OldPhonePad(yourInputs) .
- by importing the Library as using namespace
```
using CodingChallenge;
```
- by fully qualified namespaces 
```
CodingChallenge.EncodingUtility(yourInputs);
```
- Method invoking from the Client Program 
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/be95820e-0163-4d6b-a0db-978a207b37cf)








