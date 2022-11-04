namespace DevFreela.Domain.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {

        public ProjectAlreadyStartedException(): base(" Project Already started") 
        { 
        }

    }
}
