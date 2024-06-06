/*The following code takes a string, reverses it, and prints it out the console,
along with the number of times the letter 'o' appears in it*/

string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;
foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}
string newMessage = new string(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");
