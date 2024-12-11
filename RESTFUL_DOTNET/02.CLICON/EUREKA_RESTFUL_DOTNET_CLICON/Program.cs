using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestClient
{
    class Program
    {
        private static bool isLoggedIn = false;

        static async Task Main(string[] args)
        {
            string baseUrl = "http://10.40.20.105:667"; // Reemplaza con la URL base de tu API

            Console.WriteLine("Bienvenido al cliente de consola para la API RESTful");

            while (!isLoggedIn)
            {
                Console.WriteLine("Debe iniciar sesión para continuar.");
                await Login(baseUrl);
            }

            while (true)
            {
                Console.WriteLine("1. Depósito");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("3. Transferencia");
                Console.WriteLine("4. Ver Movimientos");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Seleccione una opción:");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        await ProcesarMovimientoMenu(baseUrl, "DEP");
                        break;
                    case "2":
                        await ProcesarMovimientoMenu(baseUrl, "RET");
                        break;
                    case "3":
                        await ProcesarMovimientoMenu(baseUrl, "TRA");
                        break;
                    case "4":
                        await LeerMovimientosMenu(baseUrl);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        static async Task Login(string baseUrl)
        {
            Console.WriteLine("Ingrese el nombre de usuario:");
            string username = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña:");
            string password = Console.ReadLine();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                var loginRequest = new
                {
                    Username = username,
                    Password = password
                };

                var content = new StringContent(JsonConvert.SerializeObject(loginRequest), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("/Login/Login", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var loginResponse = JsonConvert.DeserializeObject<dynamic>(responseData);

                    if (loginResponse.success == true)
                    {
                        isLoggedIn = true;
                        Console.WriteLine("Login exitoso.");
                    }
                    else
                    {
                        Console.WriteLine("Login fallido: " + loginResponse.message);
                    }
                }
                else
                {
                    Console.WriteLine($"Login Error: {response.StatusCode}");
                }
            }
        }

        static async Task LeerMovimientosMenu(string baseUrl)
        {
            Console.WriteLine("Ingrese el número de cuenta:");
            string cuenta = Console.ReadLine();

            await LeerMovimientos(baseUrl, cuenta);
        }

        static async Task LeerMovimientos(string baseUrl, string cuenta)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = await client.GetAsync($"/Eureka/LeerMovimientos?cuenta={cuenta}");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var movimientos = JsonConvert.DeserializeObject<dynamic>(responseData);

                    Console.WriteLine("Movimientos:");
                    Console.WriteLine("#Movimiento\tFecha\t\tTipo de Acción\tMonto");

                    foreach (var movimiento in movimientos)
                    {
                        Console.WriteLine($"{movimiento.NroMov}\t\t{movimiento.Fecha}\t{movimiento.Accion}\t\t{movimiento.Importe}");
                    }
                }
                else
                {
                    Console.WriteLine($"LeerMovimientos Error: {response.StatusCode}");
                }
            }
        }

        static async Task ProcesarMovimientoMenu(string baseUrl, string tipo)
        {
            Console.WriteLine("Ingrese el código de la cuenta:");
            string codigoCuenta = Console.ReadLine();
            Console.WriteLine("Ingrese el valor del movimiento:");
            string valorMovimiento = Console.ReadLine();

            string cuentaDest = null;
            if (tipo == "TRA")
            {
                Console.WriteLine("Ingrese el código de la cuenta destino:");
                cuentaDest = Console.ReadLine();
            }

            var movimientoRequest = new MovimientoRequest
            {
                CodigoCuenta = codigoCuenta,
                Tipo = tipo,
                ValorMovimiento = valorMovimiento,
                CuentaDest = cuentaDest
            };

            await ProcesarMovimiento(baseUrl, movimientoRequest);
        }

        static async Task ProcesarMovimiento(string baseUrl, MovimientoRequest movimientoRequest)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                var content = new StringContent(JsonConvert.SerializeObject(movimientoRequest), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("/Eureka/ProcesarMovimiento", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("ProcesarMovimiento Response:");
                    Console.WriteLine(responseData);
                }
                else
                {
                    Console.WriteLine($"ProcesarMovimiento Error: {response.StatusCode}");
                }
            }
        }
    }

    public class MovimientoRequest
    {
        public string CodigoCuenta { get; set; }
        public string Tipo { get; set; }
        public string ValorMovimiento { get; set; }
        public string CuentaDest { get; set; }
    }
}