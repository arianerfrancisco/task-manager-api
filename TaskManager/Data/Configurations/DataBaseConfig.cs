namespace TaskManager.Data.Configurations;

public class DataBaseConfig : IDataBaseConfig
{
    public string DataBaseName { get; set; }
    public string ConnectionString { get; set; }
}