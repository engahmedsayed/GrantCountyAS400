namespace GrantCountyAs400.Domain.Accounting
{
    public class JobCode
    {
        public int Id { get; }
        public string Title { get; }
        public string Code { get; }

        public JobCode(int id, string title, string code)
        {
            Id = id;
            Title = title;
            Code = code;
        }
    }
}