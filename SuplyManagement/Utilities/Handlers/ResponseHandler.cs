namespace SuplyManagement.Utilities.Handlers
{
    public class ResponseHandler<TEntity>
    {
        public int Code { get; set; }
        public string Status { get; set; } = null!;
        public string Message { get; set; } = null!;
        public TEntity? Data { get; set; }
    }
}
