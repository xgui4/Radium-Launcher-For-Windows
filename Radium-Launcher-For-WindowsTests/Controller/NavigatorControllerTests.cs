using Moq;
using Radium_Launcher_For_Windows.View;
using Radium_Launcher_For_Windows.Controller;
using Radium_Launcher;

[TestClass]
public class NavigatorControllerTests
{
    [TestMethod]
    public void TestNavigateToPage2()
    {
        // Arrange
        var mockMainWindow = new Mock<MainWindow>();
        mockMainWindow.Setup(m => m.Width).Returns(800);
        mockMainWindow.Setup(m => m.Height).Returns(600);
        mockMainWindow.Setup(m => m.Title).Returns("Main Window");

        var mockPage2 = new Mock<Page2>();
        mockPage2.SetupProperty(m => m.Width);
        mockPage2.SetupProperty(m => m.Height);
        mockPage2.SetupProperty(m => m.Title);

        // Act
        NavigatorController.NavigateToPage2(mockMainWindow.Object);

        // Assert
        mockPage2.VerifySet(m => m.Width = 800);
        mockPage2.VerifySet(m => m.Height = 600);
        mockPage2.VerifySet(m => m.Title = "Main Window");
        mockMainWindow.Verify(m => m.Hide(), Times.Once);
        mockPage2.Verify(m => m.Show(), Times.Once);
    }
}
