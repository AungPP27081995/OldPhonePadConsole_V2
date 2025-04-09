using OldPhonePadCore.Interfaces;

namespace OldPhonePadCore.Keypads
{
    public class EnglishKeypad : IKeypad
    {
        public Dictionary<char, string> GetKeyMappings() => new()
        {
            ['1'] = ".,?!",
            ['2'] = "ABC",
            ['3'] = "DEF",
            ['4'] = "GHI",
            ['5'] = "JKL",
            ['6'] = "MNO",
            ['7'] = "PQRS",
            ['8'] = "TUV",
            ['9'] = "WXYZ",
            ['0'] = " "
        };
    }
}
