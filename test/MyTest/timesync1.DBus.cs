using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Tmds.DBus;

[assembly: InternalsVisibleTo(Tmds.DBus.Connection.DynamicAssemblyName)]
namespace timesync1.DBus
{
    [DBusInterface("org.freedesktop.LogControl1")]
    interface ILogControl1 : IDBusObject
    {
        Task<T> GetAsync<T>(string prop);
        Task<LogControl1Properties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    class LogControl1Properties
    {
        private string _LogLevel = default(string);
        public string LogLevel
        {
            get
            {
                return _LogLevel;
            }

            set
            {
                _LogLevel = (value);
            }
        }

        private string _LogTarget = default(string);
        public string LogTarget
        {
            get
            {
                return _LogTarget;
            }

            set
            {
                _LogTarget = (value);
            }
        }

        private string _SyslogIdentifier = default(string);
        public string SyslogIdentifier
        {
            get
            {
                return _SyslogIdentifier;
            }

            set
            {
                _SyslogIdentifier = (value);
            }
        }
    }

    static class LogControl1Extensions
    {
        public static Task<string> GetLogLevelAsync(this ILogControl1 o) => o.GetAsync<string>("LogLevel");
        public static Task<string> GetLogTargetAsync(this ILogControl1 o) => o.GetAsync<string>("LogTarget");
        public static Task<string> GetSyslogIdentifierAsync(this ILogControl1 o) => o.GetAsync<string>("SyslogIdentifier");
        public static Task SetLogLevelAsync(this ILogControl1 o, string val) => o.SetAsync("LogLevel", val);
        public static Task SetLogTargetAsync(this ILogControl1 o, string val) => o.SetAsync("LogTarget", val);
    }

    [DBusInterface("org.freedesktop.timesync1.Manager")]
    interface IManager : IDBusObject
    {
        Task SetRuntimeNTPServersAsync(string[] RuntimeServers);
        Task<T> GetAsync<T>(string prop);
        Task<ManagerProperties> GetAllAsync();
        Task SetAsync(string prop, object val);
        Task<IDisposable> WatchPropertiesAsync(Action<PropertyChanges> handler);
    }

    [Dictionary]
    class ManagerProperties
    {
        private string[] _LinkNTPServers = default(string[]);
        public string[] LinkNTPServers
        {
            get
            {
                return _LinkNTPServers;
            }

            set
            {
                _LinkNTPServers = (value);
            }
        }

        private string[] _SystemNTPServers = default(string[]);
        public string[] SystemNTPServers
        {
            get
            {
                return _SystemNTPServers;
            }

            set
            {
                _SystemNTPServers = (value);
            }
        }

        private string[] _RuntimeNTPServers = default(string[]);
        public string[] RuntimeNTPServers
        {
            get
            {
                return _RuntimeNTPServers;
            }

            set
            {
                _RuntimeNTPServers = (value);
            }
        }

        private string[] _FallbackNTPServers = default(string[]);
        public string[] FallbackNTPServers
        {
            get
            {
                return _FallbackNTPServers;
            }

            set
            {
                _FallbackNTPServers = (value);
            }
        }

        private string _ServerName = default(string);
        public string ServerName
        {
            get
            {
                return _ServerName;
            }

            set
            {
                _ServerName = (value);
            }
        }

        private (int, byte[]) _ServerAddress = default((int, byte[]));
        public (int, byte[]) ServerAddress
        {
            get
            {
                return _ServerAddress;
            }

            set
            {
                _ServerAddress = (value);
            }
        }

        private ulong _RootDistanceMaxUSec = default(ulong);
        public ulong RootDistanceMaxUSec
        {
            get
            {
                return _RootDistanceMaxUSec;
            }

            set
            {
                _RootDistanceMaxUSec = (value);
            }
        }

        private ulong _PollIntervalMinUSec = default(ulong);
        public ulong PollIntervalMinUSec
        {
            get
            {
                return _PollIntervalMinUSec;
            }

            set
            {
                _PollIntervalMinUSec = (value);
            }
        }

        private ulong _PollIntervalMaxUSec = default(ulong);
        public ulong PollIntervalMaxUSec
        {
            get
            {
                return _PollIntervalMaxUSec;
            }

            set
            {
                _PollIntervalMaxUSec = (value);
            }
        }

        private ulong _PollIntervalUSec = default(ulong);
        public ulong PollIntervalUSec
        {
            get
            {
                return _PollIntervalUSec;
            }

            set
            {
                _PollIntervalUSec = (value);
            }
        }

        private (uint, uint, uint, uint, int, ulong, ulong, byte[], ulong, ulong, ulong, ulong, bool, ulong, ulong) _NTPMessage = default((uint, uint, uint, uint, int, ulong, ulong, byte[], ulong, ulong, ulong, ulong, bool, ulong, ulong));
        public (uint, uint, uint, uint, int, ulong, ulong, byte[], ulong, ulong, ulong, ulong, bool, ulong, ulong) NTPMessage
        {
            get
            {
                return _NTPMessage;
            }

            set
            {
                _NTPMessage = (value);
            }
        }

        private long _Frequency = default(long);
        public long Frequency
        {
            get
            {
                return _Frequency;
            }

            set
            {
                _Frequency = (value);
            }
        }
    }

    static class ManagerExtensions
    {
        public static Task<string[]> GetLinkNTPServersAsync(this IManager o) => o.GetAsync<string[]>("LinkNTPServers");
        public static Task<string[]> GetSystemNTPServersAsync(this IManager o) => o.GetAsync<string[]>("SystemNTPServers");
        public static Task<string[]> GetRuntimeNTPServersAsync(this IManager o) => o.GetAsync<string[]>("RuntimeNTPServers");
        public static Task<string[]> GetFallbackNTPServersAsync(this IManager o) => o.GetAsync<string[]>("FallbackNTPServers");
        public static Task<string> GetServerNameAsync(this IManager o) => o.GetAsync<string>("ServerName");
        public static Task<(int, byte[])> GetServerAddressAsync(this IManager o) => o.GetAsync<(int, byte[])>("ServerAddress");
        public static Task<ulong> GetRootDistanceMaxUSecAsync(this IManager o) => o.GetAsync<ulong>("RootDistanceMaxUSec");
        public static Task<ulong> GetPollIntervalMinUSecAsync(this IManager o) => o.GetAsync<ulong>("PollIntervalMinUSec");
        public static Task<ulong> GetPollIntervalMaxUSecAsync(this IManager o) => o.GetAsync<ulong>("PollIntervalMaxUSec");
        public static Task<ulong> GetPollIntervalUSecAsync(this IManager o) => o.GetAsync<ulong>("PollIntervalUSec");
        public static Task<(uint, uint, uint, uint, int, ulong, ulong, byte[], ulong, ulong, ulong, ulong, bool, ulong, ulong)> GetNTPMessageAsync(this IManager o) => o.GetAsync<(uint, uint, uint, uint, int, ulong, ulong, byte[], ulong, ulong, ulong, ulong, bool, ulong, ulong)>("NTPMessage");
        public static Task<long> GetFrequencyAsync(this IManager o) => o.GetAsync<long>("Frequency");
    }
}