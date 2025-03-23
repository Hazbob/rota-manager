namespace rota_manager.Errors
{
    public class NoDbConnectionStringException : Exception
    {
        public NoDbConnectionStringException(): base ("No database connection string was provided") { }
    }
}
