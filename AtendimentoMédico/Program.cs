using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoMedico
{
    // Classe que representa um paciente
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Paciente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Nome: {Nome}";
        }
    }

    // Classe para Vetores
    public class VetorPacientes
    {
        private Paciente[] vetor;
        private int count;

        public VetorPacientes(int tamanho)
        {
            vetor = new Paciente[tamanho];
            count = 0;
        }

        public bool Inserir(Paciente p)
        {
            if (count >= vetor.Length)
                return false;

            vetor[count++] = p;
            return true;
        }

        public bool Remover(int id)
        {
            int pos = BuscarPosicao(id);
            if (pos == -1)
                return false;

            for (int i = pos; i < count - 1; i++)
            {
                vetor[i] = vetor[i + 1];
            }
            vetor[--count] = null;
            return true;
        }

        public Paciente Buscar(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (vetor[i].Id == id)
                    return vetor[i];
            }
            return null;
        }

        public void ExibirTodos()
        {
            if (count == 0)
            {
                Console.WriteLine("Vetor vazio.");
                return;
            }
            Console.WriteLine("Pacientes no vetor:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        private int BuscarPosicao(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (vetor[i].Id == id)
                    return i;
            }
            return -1;
        }
    }

    // Classe para Matrizes
    public class MatrizPacientes
    {
        private Paciente[,] matriz;
        private int linhas;
        private int colunas;

        public MatrizPacientes(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            matriz = new Paciente[linhas, colunas];
        }

        public bool Inserir(int linha, int coluna, Paciente p)
        {
            if (linha < 0 || linha >= linhas || coluna < 0 || coluna >= colunas)
                return false;

            matriz[linha, coluna] = p;
            return true;
        }

        public Paciente Remover(int linha, int coluna)
        {
            if (linha < 0 || linha >= linhas || coluna < 0 || coluna >= colunas)
                return null;

            var paciente = matriz[linha, coluna];
            matriz[linha, coluna] = null;
            return paciente;
        }

        public Paciente Buscar(int id)
        {
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    if (matriz[i, j]?.Id == id)
                        return matriz[i, j];

            return null;
        }

        public void ExibirTodos()
        {
            Console.WriteLine("Pacientes na matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] != null)
                        Console.Write($"[{i},{j}] {matriz[i, j]}  ");
                    else
                        Console.Write($"[{i},{j}] vazio  ");
                }
                Console.WriteLine();
            }
        }
    }

    // Classe para Lista de pacientes
    public class ListaPacientes
    {
        private List<Paciente> lista = new List<Paciente>();

        public void Inserir(Paciente p)
        {
            lista.Add(p);
        }

        public bool Remover(int id)
        {
            var paciente = Buscar(id);
            if (paciente != null)
            {
                lista.Remove(paciente);
                return true;
            }
            return false;
        }

        public Paciente Buscar(int id)
        {
            return lista.Find(p => p.Id == id);
        }

        public void ExibirTodos()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }
            Console.WriteLine("Pacientes na lista:");
            lista.ForEach(p => Console.WriteLine(p));
        }
    }

    // Classe para Fila (FIFO)
    public class FilaPacientes
    {
        private Queue<Paciente> fila = new Queue<Paciente>();

        public void Enfileirar(Paciente p)
        {
            fila.Enqueue(p);
        }

        public Paciente Desenfileirar()
        {
            if (fila.Count == 0)
                return null;
            return fila.Dequeue();
        }

        public Paciente Buscar(int id)
        {
            foreach (var p in fila)
            {
                if (p.Id == id)
                    return p;
            }
            return null;
        }

        public void ExibirTodos()
        {
            if (fila.Count == 0)
            {
                Console.WriteLine("Fila vazia.");
                return;
            }
            Console.WriteLine("Pacientes na fila:");
            foreach (var p in fila)
            {
                Console.WriteLine(p);
            }
        }
    }

    // Classe para Pilha (LIFO)
    public class PilhaPacientes
    {
        private Stack<Paciente> pilha = new Stack<Paciente>();

        public void Empilhar(Paciente p)
        {
            pilha.Push(p);
        }

        public Paciente Desempilhar()
        {
            if (pilha.Count == 0)
                return null;
            return pilha.Pop();
        }

        public Paciente Buscar(int id)
        {
            foreach (var p in pilha)
            {
                if (p.Id == id)
                    return p;
            }
            return null;
        }

        public void ExibirTodos()
        {
            if (pilha.Count == 0)
            {
                Console.WriteLine("Pilha vazia.");
                return;
            }
            Console.WriteLine("Pacientes na pilha:");
            foreach (var p in pilha)
            {
                Console.WriteLine(p);
            }
        }
    }

    // Algoritmos de Pesquisa
    public static class Pesquisa
    {
        // Pesquisa sequencial (linear) em vetor
        public static Paciente PesquisaSequencial(Paciente[] vetor, int count, int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (vetor[i]?.Id == id)
                    return vetor[i];
            }
            return null;
        }

        // Pesquisa binária requer vetor ordenado por ID
        public static Paciente PesquisaBinaria(Paciente[] vetor, int count, int id)
        {
            int inicio = 0;
            int fim = count - 1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (vetor[meio] == null)
                    return null;

                if (vetor[meio].Id == id)
                    return vetor[meio];
                else if (vetor[meio].Id < id)
                    inicio = meio + 1;
                else
                    fim = meio - 1;
            }
            return null;
        }

        // Bubble sort simples para ordenar vetor pelo Id
        public static void OrdenarPorId(Paciente[] vetor, int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    if (vetor[j] != null && vetor[j + 1] != null && vetor[j].Id > vetor[j + 1].Id)
                    {
                        var temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }
        }
    }

    // Programa principal e menus
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMenuPrincipal();
        }

        static void ExibirMenuPrincipal()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Atendimento Médico ===");
                Console.WriteLine("1. Trabalhar com Vetores");
                Console.WriteLine("2. Trabalhar com Matrizes");
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa (Binária e Sequencial)");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuVetor();
                        break;
                    case "2":
                        MenuMatriz();
                        break;
                    case "3":
                        MenuLista();
                        break;
                    case "4":
                        MenuFila();
                        break;
                    case "5":
                        MenuPilha();
                        break;
                    case "6":
                        MenuPesquisa();
                        break;
                    case "0":
                        sair = true;
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
        }

        // Menus para cada estrutura

        static void MenuVetor()
        {
            var vetor = new VetorPacientes(10);
            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("== Vetores ==");
                Console.WriteLine("1. Inserir paciente");
                Console.WriteLine("2. Remover paciente");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Buscar paciente");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        var paciente = LerPaciente();
                        if (vetor.Inserir(paciente))
                            Console.WriteLine("Paciente inserido com sucesso.");
                        else
                            Console.WriteLine("Vetor cheio.");
                        Pausar();
                        break;

                    case "2":
                        Console.Write("Informe o ID para remover: ");
                        if (int.TryParse(Console.ReadLine(), out int idRemover))
                        {
                            if (vetor.Remover(idRemover))
                                Console.WriteLine("Paciente removido.");
                            else
                                Console.WriteLine("Paciente não encontrado.");
                        }
                        else
                            Console.WriteLine("ID inválido.");
                        Pausar();
                        break;

                    case "3":
                        vetor.ExibirTodos();
                        Pausar();
                        break;

                    case "4":
                        Console.Write("Informe o ID para buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int idBuscar))
                        {
                            var p = vetor.Buscar(idBuscar);
                            Console.WriteLine(p != null ? $"Encontrado: {p}" : "Paciente não encontrado.");
                        }
                        else
                            Console.WriteLine("ID inválido.");
                        Pausar();
                        break;

                    case "0":
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuMatriz()
        {
            Console.WriteLine("Informe número de linhas da matriz:");
            int linhas = LerNumeroPositivo();
            Console.WriteLine("Informe número de colunas da matriz:");
            int colunas = LerNumeroPositivo();

            var matriz = new MatrizPacientes(linhas, colunas);

            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("== Matrizes ==");
                Console.WriteLine("1. Inserir paciente");
                Console.WriteLine("2. Remover paciente");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Buscar paciente");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Informe linha:");
                        int lin = LerNumeroPositivo() - 1;
                        Console.WriteLine("Informe coluna:");
                        int col = LerNumeroPositivo() - 1;
                        var paciente = LerPaciente();
                        if (matriz.Inserir(lin, col, paciente))
                            Console.WriteLine("Paciente inserido na matriz.");
                        else
                            Console.WriteLine("Posição inválida.");
                        Pausar();
                        break;

                    case "2":
                        Console.WriteLine("Informe linha para remover:");
                        lin = LerNumeroPositivo() - 1;
                        Console.WriteLine("Informe coluna para remover:");
                        col = LerNumeroPositivo() - 1;
                        var removido = matriz.Remover(lin, col);
                        if (removido != null)
                            Console.WriteLine($"Paciente removido: {removido}");
                        else
                            Console.WriteLine("Posição inválida ou vazia.");
                        Pausar();
                        break;

                    case "3":
                        matriz.ExibirTodos();
                        Pausar();
                        break;

                    case "4":
                        Console.WriteLine("Informe ID para buscar:");
                        if (int.TryParse(Console.ReadLine(), out int idBuscar))
                        {
                            var p = matriz.Buscar(idBuscar);
                            Console.WriteLine(p != null ? $"Encontrado: {p}" : "Paciente não encontrado.");
                        }
                        else
                            Console.WriteLine("ID inválido.");
                        Pausar();
                        break;

                    case "0":
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuLista()
        {
            var lista = new ListaPacientes();
            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("== Lista ==");
                Console.WriteLine("1. Inserir paciente");
                Console.WriteLine("2. Remover paciente");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Buscar paciente");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        var paciente = LerPaciente();
                        lista.Inserir(paciente);
                        Console.WriteLine("Paciente inserido.");
                        Pausar();
                        break;

                    case "2":
                        Console.Write("Informe ID para remover: ");
                        if (int.TryParse(Console.ReadLine(), out int idRemover))
                        {
                            if (lista.Remover(idRemover))
                                Console.WriteLine("Paciente removido.");
                            else
                                Console.WriteLine("Paciente não encontrado.");
                        }
                        else
                            Console.WriteLine("ID inválido.");
                        Pausar();
                        break;

                    case "3":
                        lista.ExibirTodos();
                        Pausar();
                        break;

                    case "4":
                        Console.Write("Informe ID para buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int idBuscar))
                        {
                            var p = lista.Buscar(idBuscar);
                            Console.WriteLine(p != null ? $"Encontrado: {p}" : "Paciente não encontrado.");
                        }
                        else
                            Console.WriteLine("ID inválido.");
                        Pausar();
                        break;

                    case "0":
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuFila()
        {
            var fila = new FilaPacientes();
            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("== Fila ==");
                Console.WriteLine("1. Enfileirar paciente");
                Console.WriteLine("2. Desenfileirar paciente");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Buscar paciente");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        var paciente = LerPaciente();
                        fila.Enfileirar(paciente);
                        Console.WriteLine("Paciente enfileirado.");
                        Pausar();
                        break;

                    case "2":
                        var removido = fila.Desenfileirar();
                        if (removido != null)
                            Console.WriteLine($"Paciente desenfileirado: {removido}");
                        else
                            Console.WriteLine("Fila vazia.");
                        Pausar();
                        break;

                    case "3":
                        fila.ExibirTodos();
                        Pausar();
                        break;

                    case "4":
                        Console.Write("Informe ID para buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int idBuscar))
                        {
                            var p = fila.Buscar(idBuscar);
                            Console.WriteLine(p != null ? $"Encontrado: {p}" : "Paciente não encontrado.");
                        }
                        else
                            Console.WriteLine("ID inválido.");
                        Pausar();
                        break;

                    case "0":
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuPilha()
        {
            var pilha = new PilhaPacientes();
            bool voltar = false;

            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("== Pilha ==");
                Console.WriteLine("1. Empilhar paciente");
                Console.WriteLine("2. Desempilhar paciente");
                Console.WriteLine("3. Exibir todos");
                Console.WriteLine("4. Buscar paciente");
                Console.WriteLine("0. Voltar");
                Console.Write("Opção: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        var paciente = LerPaciente();
                        pilha.Empilhar(paciente);
                        Console.WriteLine("Paciente empilhado.");
                        Pausar();
                        break;

                    case "2":
                        var removido = pilha.Desempilhar();
                        if (removido != null)
                            Console.WriteLine($"Paciente desempilhado: {removido}");
                        else
                            Console.WriteLine("Pilha vazia.");
                        Pausar();
                        break;

                    case "3":
                        pilha.ExibirTodos();
                        Pausar();
                        break;

                    case "4":
                        Console.Write("Informe ID para buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int idBuscar))
                        {
                            var p = pilha.Buscar(idBuscar);
                            Console.WriteLine(p != null ? $"Encontrado: {p}" : "Paciente não encontrado.");
                        }
                        else
                            Console.WriteLine("ID inválido.");
                        Pausar();
                        break;

                    case "0":
                        voltar = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
        }

        static void MenuPesquisa()
        {
            Console.WriteLine("Escolha uma estrutura de dados:");
            Console.WriteLine("1. Vetor");
            Console.WriteLine("0. Voltar");
            Console.Write("Opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.WriteLine("Informe o tamanho do vetor:");
                    int tamanhoVetor = LerNumeroPositivo();
                    var vetor = new Paciente[tamanhoVetor];
                    int count = 0;

                    bool sair = false;
                    while (!sair)
                    {
                        Console.Clear();
                        Console.WriteLine("== Pesquisa em Vetor ==");
                        Console.WriteLine("1. Inserir paciente");
                        Console.WriteLine("2. Exibir vetor");
                        Console.WriteLine("3. Pesquisa Sequencial");
                        Console.WriteLine("4. Pesquisa Binária");
                        Console.WriteLine("0. Voltar");
                        Console.Write("Opção: ");
                        string opcaoPesquisa = Console.ReadLine();

                        switch (opcaoPesquisa)
                        {
                            case "1":
                                if (count >= vetor.Length)
                                {
                                    Console.WriteLine("Vetor cheio!");
                                    Pausar();
                                    break;
                                }

                                var paciente = LerPaciente();
                                vetor[count++] = paciente;
                                Console.WriteLine("Paciente inserido.");
                                Pausar();
                                break;

                            case "2":
                                if (count == 0)
                                {
                                    Console.WriteLine("Vetor vazio.");
                                }
                                else
                                {
                                    Console.WriteLine("Pacientes no vetor:");
                                    for (int i = 0; i < count; i++)
                                    {
                                        Console.WriteLine(vetor[i]);
                                    }
                                }
                                Pausar();
                                break;

                            case "3":
                                Console.Write("Informe o ID para busca sequencial: ");
                                if (int.TryParse(Console.ReadLine(), out int idSeq))
                                {
                                    var pacienteSeq = Pesquisa.PesquisaSequencial(vetor, count, idSeq);
                                    Console.WriteLine(pacienteSeq != null ? $"Paciente encontrado: {pacienteSeq}" : "Paciente não encontrado.");
                                }
                                else
                                    Console.WriteLine("ID inválido.");
                                Pausar();
                                break;

                            case "4":
                                Pesquisa.OrdenarPorId(vetor, count);
                                Console.WriteLine("Vetor ordenado:");
                                for (int i = 0; i < count; i++)
                                {
                                    Console.WriteLine(vetor[i]);
                                }

                                Console.Write("Informe o ID para busca binária: ");
                                if (int.TryParse(Console.ReadLine(), out int idBin))
                                {
                                    var pacienteBin = Pesquisa.PesquisaBinaria(vetor, count, idBin);
                                    Console.WriteLine(pacienteBin != null ? $"Paciente encontrado: {pacienteBin}" : "Paciente não encontrado.");
                                }
                                else
                                    Console.WriteLine("ID inválido.");
                                Pausar();
                                break;

                            case "0":
                                sair = true;
                                break;

                            default:
                                Console.WriteLine("Opção inválida.");
                                Pausar();
                                break;
                        }
                    }
                    break;

                case "0":
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    Pausar();
                    break;
            }
        }

        static Paciente LerPaciente()
        {
            Console.Write("Informe o ID do paciente (número inteiro): ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("ID inválido. Informe o ID do paciente (número inteiro): ");
            }

            Console.Write("Informe o nome do paciente: ");
            string nome = Console.ReadLine();

            return new Paciente(id, nome);
        }

        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }


        static int LerNumeroPositivo()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Por favor, insira um número positivo: ");
            }
            return valor;
        }
    }
}