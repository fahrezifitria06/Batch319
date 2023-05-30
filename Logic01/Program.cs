
//Konversi();
OperatorAritmatika();

Console.ReadKey();

static void OperatorAritmatika()
{
    int mangga, apel, hasil = 0;

    Console.WriteLine("--Operator Aritmatika--");
    Console.Write("Masukkan mangga : ");
    mangga = int.Parse(Console.ReadLine());
    Console.Write("Masukkan apel : ");
    apel = int.Parse(Console.ReadLine());

    hasil = mangga + apel;

    string nama = "Petani" + 10;
    int angka = int.Parse(Console.ReadLine());

    Console.WriteLine($"Hasil mangga + apel = {hasil}");

}

static void Konversi()
{
    Console.WriteLine("---KONVERSI---");

    int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;

    string strMyInt = Convert.ToString(myInt);
    string strMyInt2 = myInt.ToString();

    Console.WriteLine(strMyInt);
    Console.WriteLine(strMyInt2);
    Console.WriteLine(Convert.ToDouble(myInt));
    Console.WriteLine(Convert.ToInt32(myDouble));
    Console.WriteLine(Convert.ToString(myBool));

}
