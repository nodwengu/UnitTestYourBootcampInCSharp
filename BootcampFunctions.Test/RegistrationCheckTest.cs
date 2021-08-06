using Xunit;

namespace BootcampFunctions.Test {
   public class RegistrationCheckTest {
      [Fact]
      public void ShouldCheckIfNumberIForGP() {
         Assert.True(RegistrationCheck.RegCheck("DV 23 NB GP", "GP"));
         Assert.False(RegistrationCheck.RegCheck("ERT 123 EC", "GP"));
         Assert.False(RegistrationCheck.RegCheck("GP 123-012", "GP"));
      }

      [Fact]
      public void ShouldCheckIfNumberIForEC() {
         Assert.True(RegistrationCheck.RegCheck("DV 23 NB EC", "EC"));
         Assert.False(RegistrationCheck.RegCheck("ERT 123 GP", "EC"));
         Assert.False(RegistrationCheck.RegCheck("EC 123-012", "EC"));
      }

      [Fact]
      public void ShouldCheckIfNumberIForMP() {
         Assert.True(RegistrationCheck.RegCheck("DV 23 NB MP", "MP"));
         Assert.False(RegistrationCheck.RegCheck("ERT 123 EC", "MP"));
         Assert.False(RegistrationCheck.RegCheck("MP 123-012", "MP"));
      }

      [Fact]
      public void ShouldCheckIfNumberIForL() {
         Assert.True(RegistrationCheck.RegCheck("DV 23 NB L", "L"));
         Assert.False(RegistrationCheck.RegCheck("ERT 123 GP", "L"));
         Assert.False(RegistrationCheck.RegCheck("L 123-012", "L"));
      }
   }
}