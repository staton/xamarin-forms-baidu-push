using Android.App;
using Android.Content;

namespace Com.Baidu.Android.Pushservice
{
    [BroadcastReceiver(Name = "com.baidu.android.pushservice.RegistrationReceiver", Process = ":bdservice_v1")]
    [IntentFilter(
        new string[]
        {
            "com.baidu.android.pushservice.action.METHOD",
            "com.baidu.android.pushservice.action.BIND_SYNC"
        }
    )]
    [IntentFilter(
        new string[]
        {
            "android.intent.action.PACKAGE_REMOVED"
        },
        DataScheme = "package"
    )]
    public partial class RegistrationReceiver
    {
    }
}