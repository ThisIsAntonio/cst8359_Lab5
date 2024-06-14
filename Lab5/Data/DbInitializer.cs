namespace Lab5.Data
{
    public class DbInitializer
    {
        public static void Initialize(SportsDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
