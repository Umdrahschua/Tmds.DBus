using timesync1.DBus;

namespace MyTest;

public class UnitTest1
{
    [Fact]
    public async void DBusAllPropertiesTest()
    {
        var systemConnection = Tmds.DBus.Connection.System;
        var timesyncManager = systemConnection.CreateProxy<timesync1.DBus.IManager>("org.freedesktop.timesync1", "/org/freedesktop/timesync1");

        var all = await timesyncManager.GetAllAsync();
        Assert.True(all != null);
    }
    [Fact]

    public async void DBusNTPMessageTest()
    {
        var systemConnection = Tmds.DBus.Connection.System;
        var timesyncManager = systemConnection.CreateProxy<timesync1.DBus.IManager>("org.freedesktop.timesync1", "/org/freedesktop/timesync1");

        var msg = await timesyncManager.GetNTPMessageAsync();
        Assert.True(msg.Item1 == 0);
    }
}
