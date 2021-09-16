using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_2_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(2, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

