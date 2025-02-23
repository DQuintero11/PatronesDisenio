using ChainResponsability;

class Program
{
    static void Main()
    {
        // Creamos la cadena de responsabilidad
        var authHandler = new AuthenticationHandler();
        var authorizationHandler = new AuthorizationHandler();
        var dataValidationHandler = new DataValidationHandler();

        authHandler.SetNext(authorizationHandler).SetNext(dataValidationHandler);

        // Solicitud con datos válidos
        var request = new Request
        {
            UserAuthenticated = true,
            UserRole = "Admin",
            Data = "Información válida"
        };

        Console.WriteLine("🔹 Procesando solicitud válida:");
        authHandler.Handle(request);

        Console.WriteLine("\n🔹 Procesando solicitud con usuario no autenticado:");
        var request2 = new Request
        {
            UserAuthenticated = false,
            UserRole = "Admin",
            Data = "Información válida"
        };
        authHandler.Handle(request2);
    }
}
