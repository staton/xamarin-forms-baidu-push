using Android.App;

namespace Com.Baidu.Android.Pushservice
{
    [Service(Name = "com.baidu.android.pushservice.PushService", Exported = true, Process = ":bdservice_v1")]
    [IntentFilter(
        new string[]
        {
            "com.baidu.android.pushservice.action.PUSH_SERVICE"
        }
    )]
    public partial class PushService
    {
    }
}