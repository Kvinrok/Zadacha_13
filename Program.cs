Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string Text = Convert.ToString(Number);
if (Text.Length > 2){
  Console.WriteLine("третья цифра -> " + Text[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}