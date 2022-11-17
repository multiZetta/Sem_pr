// Написать метод, который проверяет валидность пароля.
// Пароль считается валидным, если:
// 1. В нём не менее 8 символов
// 2. В пароле должен быть хотя бы один символ из набора !№;%:?*()
// 3. В пароле не должно быть знака равно "="
// 4. В пароле должна обязательно должна быть одна латинская 
//    заглавная буква
// 
// Q123456!
// q123456!


// C12312%
bool Check(string password)
{
  if (password.Length < 8) return false;

  int i = 0;
  bool flag = false;
  while (i < password.Length)
  {
    if ("!№;%:?*()".IndexOf(password[i]) != -1) flag = true;
    i++;
  }
  if (flag == false) return false;

  if (password.IndexOf('=') != -1) return false;

  i = 0;
  int count = 0;
  while (i < password.Length)
  {
    if (password[i] >= 'A' && password[i] <= 'Z') count++;
    i++;
  }
  if (count != 1) return false;

  return true;
}

string[] GetPasswordsList(string path)
{
  return File.ReadAllLines(path);
}

string[] passwords = GetPasswordsList("list.txt");
int i = 0;
while (i < passwords.Length)
{
  bool result = Check(passwords[i]);
  if (result)
  {
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(result + ": " + passwords[i]);
    File.AppendAllText("result.csv", result + ";" + passwords[i] + ";+\n");
  }
  else
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(result + ": " + passwords[i]);
    File.AppendAllText("result.csv", result + ";" + passwords[i] + ";-\n");
  }
  i++;
}