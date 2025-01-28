// Zadanie domowe dzień 5

int number = 20010701;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] digits = new int[10];

foreach (var letter in letters)
{
    digits[letter - '0'] += 1;
}

for (int i = 0; i < digits.Length; i++)
{
    Console.WriteLine(i.ToString() + " => " + digits[i]);
}