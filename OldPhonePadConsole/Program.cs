using OldPhonePadCore;
using OldPhonePadCore.Interfaces;
using OldPhonePadCore.Keypads;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Old Phone Pad Simulator");
Console.WriteLine("Press Choose Language English or Thai (E\\T) \n");

var Lang = Console.ReadKey(intercept: false);
if (Lang.KeyChar == 'E' || Lang.KeyChar == 'e')
{
    Console.Clear();
    var pad = new PhonePad(new EnglishKeypad());    
    Console.WriteLine("Press keys to type (like old mobile phones). Press # to finish.\n");
    while (true)
    {
        var key = Console.ReadKey(intercept: false);

        pad.ProcessKey(key);

        if (key.KeyChar == '#')        {
            
            Console.WriteLine($"\nOutput: {pad.GetResult()} ");
        }
    }
}
else if (Lang.KeyChar == 'T' || Lang.KeyChar == 't')
{
    Console.Clear();
    var padT = new PhonePad(new ThaiKeypad());
    Console.WriteLine("กดแป้นเพื่อพิมพ์ (เหมือนโทรศัพท์มือถือรุ่นเก่า) กด # เพื่อสิ้นสุดการพิมพ์.\n");
    while (true)
    {
        var key = Console.ReadKey(intercept: false);

        padT.ProcessKey(key);

        if (key.KeyChar == '#')
        {

            Console.WriteLine($"\nOutput: {padT.GetResult()} ");
        }
    }
}
else
{
    Console.WriteLine("Please Enter Valid Keyword.\n");
}








       
