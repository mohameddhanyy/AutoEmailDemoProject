using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Services;

namespace AutoEmailDemoProject.Services;

public class CustomConnectionProviderService : IConnectionProviderService
{
    public SqlDataConnection LoadConnection(string connectionName)
    {
        var Con = new SqlDataConnection()
        {
            ConnectionString = MainDataContext.ConnStrMain,
            Name = "MainDataContext_Connection",
        };
        return Con;
    }

    public string LoadConnection()
    {
        return MainDataContext.ConnStrMain;
    }
}