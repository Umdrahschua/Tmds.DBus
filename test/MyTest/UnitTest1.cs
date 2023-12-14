namespace MyTest;

public class UnitTest1
{
    [Fact]
    public async void DBusTest1()
    {
        var systemConnection = Tmds.DBus.Connection.System;
        var timesyncManager = systemConnection.CreateProxy<timesync1.DBus.IManager>("org.freedesktop.timesync1", "/org/freedesktop/timesync1");

        var all = await timesyncManager.GetAllAsync();
        Assert.True(all != null);
    }
}
