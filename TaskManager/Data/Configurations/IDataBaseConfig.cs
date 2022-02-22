namespace TaskManager.Data.Configurations;

public interface IDataBaseConfig
{
    public string DataBaseName { get; set; }
    public string ConnectionString { get; set; }
}