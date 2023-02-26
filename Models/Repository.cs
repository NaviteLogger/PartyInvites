namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}

/* I am going to do this by creating an in-memory 
 * collection of objects.This isn’t useful in a 
 * real application because the response data will
 * be lost when the application is stopped or restarted,
 * but this approach will allow me to keep the focus on
 * ASP.NET Core and create an application that can easily 
 * be reset to its initial state.
 */