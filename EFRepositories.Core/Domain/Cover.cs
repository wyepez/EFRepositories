namespace EFRepositories.Core.Domain
{
    public class Cover
    {
        public int Id { get; set; }
        public virtual Course Course { get; set; }
    }
}
