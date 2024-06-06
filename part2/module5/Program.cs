string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}
// convert it back to a string
string newMessage = new string(charMessage);
// print it out
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");
