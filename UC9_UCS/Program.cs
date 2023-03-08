//CRIANDO AS VARÁVEIS
string[,] matriz = new string[5, 4];
int op, l, c, uc;
double duracao;


//DANDO VALOR AS VARIÁVEIS
duracao = 0;
uc = 0;
op = 0;
l = 0;
c = 0;
matriz[0, 1] = "0";
matriz[0, 2] = "1";
matriz[0, 3] = "2";
matriz[0, 4] = "3";
matriz[0, 5] = "4";

//SWITCH
Console.WriteLine("1 - CADASTRAR AS UCs DO CURSO");
Console.WriteLine("2 - IFORMAÇÕES");

switch (op)
{
    //CADASTRO
    case 1:

        for (l = 0; l < 5; l++)
        {
            for (c = 1; c < 4; c++)
            {
                if (c == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Qual o NÚMERO da UC?");
                    matriz[l, c] = Console.ReadLine();
                }
                if (c == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Qual a DESCRIÇÃO da UC?");
                    matriz[l, c] = Console.ReadLine();
                }
                if (c == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Qual a CARGA HORARIA da UC?");
                    matriz[l, c] = Console.ReadLine();
                }
            }
        }

    break;

    //INFORMAÇÕES
    case 2:
        
        Console.Clear();

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 4; c++)
            {
               Console.Write(" " + matriz[l, c] + " ");
            }
            Console.WriteLine("");
        }

        Console.WriteLine("\n\nPor qual UC deseja pesquisar? (utilise o NUMERO de linhas)");
        uc = int.Parse(Console.ReadLine());
        Console.Write(matriz[uc, c]);

        Console.WriteLine("para saber quantas FALTAS vc pode ter clique ENTER");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Qual a duração de aula diária?");
        duracao = double.Parse(Console.ReadLine());

        Console.WriteLine();

        

        Console.Clear();

    break;
}