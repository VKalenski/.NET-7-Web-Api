namespace dotnet_rpg.Models
{
    public class ServiceResponse<T>
    {
        #region Properties ServiceResponse
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
        #endregion
    }
}