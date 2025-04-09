using OldPhonePadCore.Interfaces;

namespace OldPhonePadCore.Keypads
{
    public class ThaiKeypad : IKeypad
    {
        public Dictionary<char, string> GetKeyMappings() => new()
        {
            ['1'] = "กขฃ",     // Example Thai characters
            ['2'] = "คฅฆ",
            ['3'] = "งจฉ",
            ['4'] = "ชซฌ",
            ['5'] = "ญฎฏ",
            ['6'] = "ฐฑฒ",
            ['7'] = "ณดต",
            ['8'] = "ถทธ",
            ['9'] = "นบป",
            ['0'] = " "        // Space
        };
    }
}
