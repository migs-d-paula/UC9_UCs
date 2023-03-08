//CRIANDO AS VARÁVEIS
string[,] matriz = new string[5, 3];
int op, l, c;

//DANDO VALOR AS VARIÁVEIS
op = 0;
l = 0;
c = 0;

//SWITCH
Console.WriteLine("1 - CADASTRAR AS UCs DO CURSO");
Console.WriteLine("2 - IFORMAÇÕES");

switch (op)
{
    //CADASTRO
    case 1:

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 3; c++)
            {
                if (c == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Qual o NÚMERO da UC?");
                    matriz[l, c] = Console.ReadLine();
                }
                if (c == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Qual a DESCRIÇÃO da UC?");
                    matriz[l, c] = Console.ReadLine();
                }
                if (c == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Qual a CARGA HORARIA da UC?");
                    matriz[l, c] = Console.ReadLine();
                }
            }
        }

    break;
}