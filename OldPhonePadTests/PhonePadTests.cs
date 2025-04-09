using OldPhonePadCore;
using OldPhonePadCore.Keypads;
using Xunit;

namespace OldPhonePadTests
{
    public class PhonePadTests
    {
        [Fact]
        public void Pressing_2_Returns_A()
        {
            var pad = new PhonePad(new EnglishKeypad());
            pad.ProcessKey(new ConsoleKeyInfo('2', ConsoleKey.D2, false, false, false));
            Assert.Equal("A", pad.GetResult());
        }

        [Fact]
        public void SingleTap_ReturnsFirstCharacter()
        {
            var pad = new PhonePad(new EnglishKeypad());
            pad.ProcessKey(new ConsoleKeyInfo('2', ConsoleKey.D2, false, false, false));
            Assert.Equal("A", pad.GetResult());
        }

        [Fact]
        public void DoubleTap_CyclesCharacters()
        {
            var pad = new PhonePad(new EnglishKeypad());
            pad.ProcessKey(new ConsoleKeyInfo('2', ConsoleKey.D2, false, false, false));
            System.Threading.Thread.Sleep(100);
            pad.ProcessKey(new ConsoleKeyInfo('2', ConsoleKey.D2, false, false, false));
            Assert.Equal("B", pad.GetResult());
        }

        [Fact]
        public void ThaiKeypad_FirstCharacterIsCorrect()
        {
            var pad = new PhonePad(new ThaiKeypad());
            pad.ProcessKey(new ConsoleKeyInfo('1', ConsoleKey.D1, false, false, false));
            Assert.Equal("ก", pad.GetResult());
        }
    }
}
