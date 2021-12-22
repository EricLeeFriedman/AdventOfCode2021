// See https://aka.ms/new-console-template for more information

/////////////////////////////////////////
// Part 1 Test Data
/////////////////////////////////////////

//string[] Inputs = new string[] {
//"00100",
//"11110",
//"10110",
//"10111",
//"10101",
//"01111",
//"00111",
//"11100",
//"10000",
//"11001",
//"00010",
//"01010" };

//int[] BinaryInputs = new int[Inputs.Length];

//for (int Bit = 0; Bit < 5; Bit++)
//{
//    int Index = 0;
//    foreach (string Input in Inputs)
//    {
//        BinaryInputs[Index] |= (int.Parse(Input[Bit].ToString()) << (4 - Bit));
//        Index++;
//    }
//}

//float Majority = Inputs.Length / 2.0f;
//int Gamma = 0;

//for (int i = 0; i < 5; i++)
//{
//    int MostCommonBit = 1;
//    int Zeros = 0;
//    foreach (int Input in BinaryInputs)
//    {
//        if ((Input & (1 << i)) == 0)
//        {
//            if (++Zeros >= Majority)
//            {
//                MostCommonBit = 0;
//                break;
//            }
//        }
//    }

//    Gamma |= (MostCommonBit << i);
//}
//int Epsilon = ~Gamma & ((1 << 5) - 1);

//Console.WriteLine(Epsilon * Gamma);

/////////////////////////////////////////
// Part 1 Answer
/////////////////////////////////////////

//string[] Inputs = File.ReadAllLines(@"Day3Input.txt");

//int[] BinaryInputs = new int[Inputs.Length];

//for (int Bit = 0; Bit < 12; Bit++)
//{
//    int Index = 0;
//    foreach (string Input in Inputs)
//    {
//        BinaryInputs[Index] |= (int.Parse(Input[Bit].ToString()) << (11 - Bit));
//        Index++;
//    }
//}

//float Majority = Inputs.Length / 2.0f;
//int Gamma = 0;

//for (int i = 0; i < 12; i++)
//{
//    int MostCommonBit = 1;
//    int Zeros = 0;
//    foreach (int Input in BinaryInputs)
//    {
//        if ((Input & (1 << i)) == 0)
//        {
//            if (++Zeros >= Majority)
//            {
//                MostCommonBit = 0;
//                break;
//            }
//        }
//    }

//    Gamma |= (MostCommonBit << i);
//}
//int Epsilon = ~Gamma & ((1 << 12) - 1);

//Console.WriteLine(Epsilon * Gamma);

/////////////////////////////////////////
// Part 2 Test Data
/////////////////////////////////////////

//string[] Inputs = new string[] {
//"00100",
//"11110",
//"10110",
//"10111",
//"10101",
//"01111",
//"00111",
//"11100",
//"10000",
//"11001",
//"00010",
//"01010" };

//int[] BinaryInputs = new int[Inputs.Length];

//for (int Bit = 0; Bit < 5; Bit++)
//{
//    int Index = 0;
//    foreach (string Input in Inputs)
//    {
//        BinaryInputs[Index] |= (int.Parse(Input[Bit].ToString()) << (4 - Bit));
//        Index++;
//    }
//}

//List<int> ValidOxygen = BinaryInputs.ToList();
//List<int> ValidC02 = BinaryInputs.ToList();

//for (int i = 4; i >= 0; i--)
//{
//    int MostCommonBit = 0;
//    int Ones = 0;
//    List<int> OxygenCopy = ValidOxygen.ToList();
//    float Majority = OxygenCopy.Count / 2.0f;
//    foreach (int Input in OxygenCopy)
//    {
//        if ((Input & (1 << i)) != 0)
//        {
//            if (++Ones >= Majority)
//            {
//                MostCommonBit = 1;
//                break;
//            }
//        }
//    }

//    foreach (int Input in OxygenCopy)
//    {
//        if (ValidOxygen.Count == 1)
//        {
//            break;
//        }

//        int OxygenCheck = MostCommonBit == 1 ? 0 : (1 << i);
//        if ((Input & (1 << i)) == OxygenCheck)
//        {
//            ValidOxygen.Remove(Input);
//        }
//    }

//    List<int> C02Copy = ValidC02.ToList();
//    Ones = 0;
//    MostCommonBit = 0;
//    Majority = C02Copy.Count / 2.0f;
//    foreach (int Input in C02Copy)
//    {
//        if ((Input & (1 << i)) != 0)
//        {
//            if (++Ones >= Majority)
//            {
//                MostCommonBit = 1;
//                break;
//            }
//        }
//    }

//    foreach (int Input in C02Copy)
//    {
//        if (ValidC02.Count == 1)
//        {
//            break;
//        }

//        int C02Check = MostCommonBit == 1 ? (1 << i) : 0 ;
//        if ((Input & (1 << i)) == C02Check)
//        {
//            ValidC02.Remove(Input);
//        }
//    }

//    if (ValidOxygen.Count == 1 && ValidC02.Count == 1)
//    {
//        break;
//    }
//}

//if (ValidOxygen.Count != 1 || ValidC02.Count != 1)
//{
//    throw new Exception("Your algorithm sucks Eric");
//}

//Console.WriteLine(ValidOxygen[0] * ValidC02[0]);

/////////////////////////////////////////
// Part 3 Answer
/////////////////////////////////////////

string[] Inputs = File.ReadAllLines(@"Day3Input.txt");

int[] BinaryInputs = new int[Inputs.Length];

for (int Bit = 0; Bit < 12; Bit++)
{
    int Index = 0;
    foreach (string Input in Inputs)
    {
        BinaryInputs[Index] |= (int.Parse(Input[Bit].ToString()) << (11 - Bit));
        Index++;
    }
}

List<int> ValidOxygen = BinaryInputs.ToList();
List<int> ValidC02 = BinaryInputs.ToList();

for (int i = 11; i >= 0; i--)
{
    int MostCommonBit = 0;
    int Ones = 0;
    List<int> OxygenCopy = ValidOxygen.ToList();
    float Majority = OxygenCopy.Count / 2.0f;
    foreach (int Input in OxygenCopy)
    {
        if ((Input & (1 << i)) != 0)
        {
            if (++Ones >= Majority)
            {
                MostCommonBit = 1;
                break;
            }
        }
    }

    foreach (int Input in OxygenCopy)
    {
        if (ValidOxygen.Count == 1)
        {
            break;
        }

        int OxygenCheck = MostCommonBit == 1 ? 0 : (1 << i);
        if ((Input & (1 << i)) == OxygenCheck)
        {
            ValidOxygen.Remove(Input);
        }
    }

    List<int> C02Copy = ValidC02.ToList();
    Ones = 0;
    MostCommonBit = 0;
    Majority = C02Copy.Count / 2.0f;
    foreach (int Input in C02Copy)
    {
        if ((Input & (1 << i)) != 0)
        {
            if (++Ones >= Majority)
            {
                MostCommonBit = 1;
                break;
            }
        }
    }

    foreach (int Input in C02Copy)
    {
        if (ValidC02.Count == 1)
        {
            break;
        }

        int C02Check = MostCommonBit == 1 ? (1 << i) : 0;
        if ((Input & (1 << i)) == C02Check)
        {
            ValidC02.Remove(Input);
        }
    }

    if (ValidOxygen.Count == 1 && ValidC02.Count == 1)
    {
        break;
    }
}

if (ValidOxygen.Count != 1 || ValidC02.Count != 1)
{
    throw new Exception("Your algorithm sucks Eric");
}

Console.WriteLine(ValidOxygen[0] * ValidC02[0]);