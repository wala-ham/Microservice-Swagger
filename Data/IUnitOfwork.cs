namespace testswagger.Data
{
    public interface IUnitOfwork
    {
        void Save();
        Task SaveAsync();
    }

    

}

