namespace Apprenticeship.Entites
{
    public class Student :Person
    {
        public string major { get; set; }

        public List<Traning> apprenticeships { get; set; }
    }
}
