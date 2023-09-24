string[] arr1 = new string[4] { "2", "hello", "world", ":-)" };
string[] arr2 = new string[arr1.Length];
int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        arr2[j] = arr1[i];
        j++;
    }
}
