namespace ExamenPracticioDAE1
{
    internal class Program
    {

        // Areglos para Musica
        static string[] artistas = new string[100];
        static string[] titulos = new string[100];
        static int[] duraciones = new int[100];
        static int[] tamanos = new int[100];
        static int totalCanciones = 0;
        //Alreglos para EStudiantes
        static string[] codigos = new string[100];
        static string[] nombres = new string[100];
        static DateTime[] fechasNacimiento = new DateTime[100];
        static string[] grados = new string[100];
        static int[] añosRegistro = new int[100];
        static int totalAlumnos = 0;
        // Areglos para libros
        static string[] codigosLibros = new string[100];
        static string[] titulosLibros = new string[100];
        static string[] autoresLibros = new string[100];
        static int[] añosPublicacionLibros = new int[100];
        static int totalLibros = 0;
        static void Main(string[] args)
        {
        //bucle para el menu pricipal
            while (true)
            {
                Console.WriteLine("====================BIENVENIDO AL MENU PRINCIPAL DEL SYSTEMA================");
                Console.WriteLine("1. Administrar musica");
                Console.WriteLine("2. Administrar Alumnos");
                Console.WriteLine("3. Administrar Libros");
                Console.WriteLine("4. Salir");
                Console.WriteLine("============================================================================");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        addmusica();
                        break;
                    case 2:
                        addAlumnos();
                        break;
                    case 3:
                        addLibros();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Esta opcion no existe ");
                        break;
                }
            }

        }
        // -------------------------SECCION DE CANCIONES  O MUSICA---------------------
        static void addmusica()
        {
            
            while (true)//declaramos el bucle
            {
                Console.WriteLine("================================= AMINISTRAR MUSICA======================");
                Console.WriteLine("1. Agregar Canción");
                Console.WriteLine("2. Mostrar Canciones");
                Console.WriteLine("3. Volver al Menú Principal");
                Console.WriteLine("============================================================================");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarCancion();
                        break;
                    case 2:
                        MostrarCanciones();
                        break;
                    case 3:
                        return;  // return me sirve para volver al menu principal
                    default:
                        Console.WriteLine("esta opcion no existe elija una valida.");
                        break;
                }
            }
        }

        static void AgregarCancion()
        {
            
            Console.WriteLine("Ingresa los datos de tu musica favorita");

            Console.Write("Artista: ");
            artistas[totalCanciones] = Console.ReadLine();

            Console.Write("Título: ");
            titulos[totalCanciones] = Console.ReadLine();

            Console.Write("Duración (en segundos): ");
            duraciones[totalCanciones] = int.Parse(Console.ReadLine());

            Console.Write("Tamaño del archivo (en KB): ");
            tamanos[totalCanciones] = int.Parse(Console.ReadLine());

            totalCanciones++;
        }

        static void MostrarCanciones()
        {
            Console.WriteLine("Listado de Canciones:");
            Console.WriteLine("Artista\t\tTítulo\t\tDuración\tTamaño (KB)");

            for (int i = 0; i < totalCanciones; i++)
            {
                Console.WriteLine($"{artistas[i]}\t\t{titulos[i]}\t\t{duraciones[i]}\t\t{tamanos[i]}");
            }
        }
        //--------------------------------SECCION DE ALUMNOS-------------------
        static void addAlumnos()
        {
            Console.Clear ();
            while (true)
            {
                Console.WriteLine("========================MENU PARA ADMINITRAR ALUMNOS ================");
                Console.WriteLine("1. Agregar Alumno");
                Console.WriteLine("2. Mostrar Alumnos");
                Console.WriteLine("3. Volver al Menú Principal");
                Console.WriteLine("=======================================================================");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarAlumno();
                        break;
                    case 2:
                        MostrarAlumnos();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
        //-----------------------------AGREGAR ALUMNOS----------------------------
        static void AgregarAlumno()

        {  
            Console.WriteLine("Ingresa los datos del alumno ");

            Console.Write("Código: ");
            codigos[totalAlumnos] = Console.ReadLine();

            Console.Write("Nombre completo: ");
            nombres[totalAlumnos] = Console.ReadLine();

            Console.Write("Fecha de nacimiento (//-//-//): ");
            fechasNacimiento[totalAlumnos] = DateTime.Parse(Console.ReadLine());

            Console.Write("Grado: ");
            grados[totalAlumnos] = Console.ReadLine();

            Console.Write("Año de registro: ");
            añosRegistro[totalAlumnos] = int.Parse(Console.ReadLine());

            totalAlumnos++;
        }

        static void MostrarAlumnos()
        {
            Console.WriteLine("Listado de Alumnos:");
            Console.WriteLine("Código\t\tNombre\t\tFecha Nacimiento\tGrado\tAño Registro");

            for (int i = 0; i < totalAlumnos; i++)
            {
                Console.WriteLine($"{codigos[i]}\t\t{nombres[i]}\t\t{fechasNacimiento[i]:yyyy-MM-dd}\t{grados[i]}\t{añosRegistro[i]}");
            }
        }
        //--------------------------------SECCION DE LIBROS--------------------------------

        static void addLibros()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("==============================MENU PARA ADMINISTRAR LIBROS=====================");
                Console.WriteLine("1. Agregar Libro");
                Console.WriteLine("2. Mostrar Libros");
                Console.WriteLine("3. Buscar Libro por Código");
                Console.WriteLine("4. Editar Información de un Libro por Código");
                Console.WriteLine("5. Volver al Menú Principal");
                Console.WriteLine("============================================================================");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarLibro();
                        break;
                    case 2:
                        MostrarLibros();
                        break;
                    case 3:
                        BuscarLibroPorCodigo();
                        break;
                    case 4:
                        EditarLibroPorCodigo();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("!!Opción no válida!!");
                        break;
                }
            }
        }

        static void AgregarLibro()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los datos del libro :");

            Console.Write("Código: ");
            codigosLibros[totalLibros] = Console.ReadLine();

            Console.Write("Título: ");
            titulosLibros[totalLibros] = Console.ReadLine();

            Console.Write("Autor: ");
            autoresLibros[totalLibros] = Console.ReadLine();

            Console.Write("Año de Publicación: ");
            añosPublicacionLibros[totalLibros] = int.Parse(Console.ReadLine());

            totalLibros++;
        }

        static void MostrarLibros()
        {
            Console.WriteLine("Listado de Libros:");
            Console.WriteLine("Código\t\tTítulo\t\tAutor\t\tAño de Publicación");

            for (int i = 0; i < totalLibros; i++)
            {
                Console.WriteLine($"{codigosLibros[i]}\t\t{titulosLibros[i]}\t\t{autoresLibros[i]}\t\t{añosPublicacionLibros[i]}");
            }
        }

        static void BuscarLibroPorCodigo()
        {
            Console.Write("Ingresa el código del libro a buscar: ");
            string codigoBuscado = Console.ReadLine();

            int indiceLibroEncontrado = -1;

            for (int i = 0; i < totalLibros; i++)
            {
                if (codigosLibros[i] == codigoBuscado)
                {
                    indiceLibroEncontrado = i;
                    break;
                }
            }

            if (indiceLibroEncontrado != -1)
            {
                Console.WriteLine("Este es el libro buscado:");
                Console.WriteLine($"Código: {codigosLibros[indiceLibroEncontrado]}");
                Console.WriteLine($"Título: {titulosLibros[indiceLibroEncontrado]}");
                Console.WriteLine($"Autor: {autoresLibros[indiceLibroEncontrado]}");
                Console.WriteLine($"Año de Publicación: {añosPublicacionLibros[indiceLibroEncontrado]}");
            }
            else
            {
                Console.WriteLine("!! LO sentimos libro no encontrado.");
            }
        }

        static void EditarLibroPorCodigo()
        {
            Console.Write("Ingresa el código del libro a editar: ");
            string codigoBuscado = Console.ReadLine();

            int indiceLibroEncontrado = -1;

            for (int i = 0; i < totalLibros; i++)
            {
                if (codigosLibros[i] == codigoBuscado)
                {
                    indiceLibroEncontrado = i;
                    break;
                }
            }

            if (indiceLibroEncontrado != -1)
            {
                Console.WriteLine("Libro encontrado. Ingresa los nuevos datos :");

                Console.Write("Título: ");
                titulosLibros[indiceLibroEncontrado] = Console.ReadLine();

                Console.Write("Autor: ");
                autoresLibros[indiceLibroEncontrado] = Console.ReadLine();

                Console.Write("Año de Publicación: ");
                añosPublicacionLibros[indiceLibroEncontrado] = int.Parse(Console.ReadLine());

                Console.WriteLine("Libro editado exitosamente.");
            }
            else
            {
                Console.WriteLine("Lo sentimos libro no encontrado.");
            }
        }
    }
}