using OldPhonePadCore.Interfaces;

namespace OldPhonePadCore
{
    public class PhonePad
    {
        public readonly IKeypad _keypad;
        public readonly Dictionary<char, string> _mappings;
        public readonly List<char> _output = new();
        public char _lastKey;
        public int _tapCount = 0;
        public DateTime _lastPressTime = DateTime.MinValue;

        public PhonePad(IKeypad keypad)
        {
            _keypad = keypad;
            _mappings = keypad.GetKeyMappings();
        }

        public void ProcessKey(ConsoleKeyInfo keyInfo)
        {
            
            char key = keyInfo.KeyChar;

            if (!_mappings.ContainsKey(key)) return;

            DateTime now = DateTime.Now;
            TimeSpan delay = now - _lastPressTime;

            if (key == _lastKey && delay.TotalMilliseconds < 1000)
            {
                _tapCount++;
                ReplaceLastChar(GetCharFromKey(key, _tapCount));
            }
            else
            {
                _tapCount = 0;
                _output.Add(GetCharFromKey(key, _tapCount));
            }

            _lastKey = key;
            _lastPressTime = now;
        }

        private char GetCharFromKey(char key, int tap)
        {
            string letters = _mappings[key];
            return letters[tap % letters.Length];
        }

        private void ReplaceLastChar(char c)
        {
            if (_output.Count > 0)
            {
                _output[_output.Count - 1] = c;
            }
        }

        public string GetResult()
        {
            string res = new string(_output.ToArray());
            _output.Clear();
           return res;

        }

    }
}
