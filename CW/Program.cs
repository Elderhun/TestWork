string[] StringArr()
{
    string resource = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*-+<=+";
    Random rnd = new Random();
    int position = 0;
    string[] strMass = new string[rnd.Next(3,9)];

    for (int i = 0; i < strMass.Length; i++)
    {
       string strEmp = string.Empty;

        for(int j = 0; j < rnd.Next(1,9); j++)
        {

        position = rnd.Next(0, resource.Length);
        strEmp += resource[position];

        }   

        strMass[i] = strEmp;

    }

return strMass;
}

string[] strArr = StringArr();
string dd; int size = 0;

for (int i = 0; i < strArr.Length; i++)
{
    dd = strArr[i];

    if(dd.Length <= 3)
    {
    size += 1;
    }

}

string[] NewStringArr(string[] resourceArr)
{
    string dd = string.Empty;

    string[] nStringArr = new string[size];
    int pos = 0;

    for (int i = 0; i < resourceArr.Length; i++)
    {
        dd = resourceArr[i];

        if(dd.Length <= 3)
        {
            nStringArr[pos] = dd;
            pos ++;
        }

    }

return nStringArr;
}

string[] ss = NewStringArr(strArr);
string printArr = "[" + string.Join(", ", strArr) + "]";
string printNewArr = "[" + string.Join(", ", ss) + "]";
Console.WriteLine(printArr + " задан рандомный строковый массив");
Console.WriteLine(printNewArr + " Новый строковый массив, длина элементов не более 3 знаков");