using Android.App;
using Android.Content;

[assembly: UsesPermission(Name = "baidu.push.permission.WRITE_PUSHINFOPROVIDER.@PACKAGE_NAME@")]
[assembly: Permission(
    Name = "baidu.push.permission.WRITE_PUSHINFOPROVIDER.@PACKAGE_NAME@",
    ProtectionLevel = Android.Content.PM.Protection.Normal
)]
namespace Com.Baidu.Android.Pushservice
{
    [ContentProvider(
        new string[]
        {
            "@PACKAGE_NAME@.bdpush"
        },
        Name = "com.baidu.android.pushservice.PushInfoProvider",
        WritePermission = "baidu.push.permission.WRITE_PUSHINFOPROVIDER.@PACKAGE_NAME@",
        Exported = true
    )]
    public partial class PushInfoProvider
    {
    }
}