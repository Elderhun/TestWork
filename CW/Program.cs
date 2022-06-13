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
