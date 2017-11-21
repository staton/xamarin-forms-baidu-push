using Android.App;
using Android.Content;

namespace Com.Baidu.Android.Pushservice
{
    [BroadcastReceiver(Name = "com.baidu.android.pushservice.PushServiceReceiver", Process = ":bdservice_v1")]
    [IntentFilter(
        new string[]
        {
            "android.intent.action.BOOT_COMPLETED",
            "android.net.conn.CONNECTIVITY_CHANGE",
            "com.baidu.android.pushservice.action.notification.SHOW",
            "com.baidu.android.pushservice.action.media.CLICK",
            "android.intent.action.MEDIA_MOUNTED",
            "android.intent.action.USER_PRESENT",
            "android.intent.action.ACTION_POWER_CONNECTED",
            "android.intent.action.ACTION_POWER_DISCONNECTED"
        }
    )]
    public partial class PushServiceReceiver
    {
    }
}