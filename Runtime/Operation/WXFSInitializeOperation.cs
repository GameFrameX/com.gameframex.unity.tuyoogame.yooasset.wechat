#if UNITY_WEBGL && ENABLE_WECHAT_MINI_GAME && WEIXINMINIGAME

using YooAsset;

namespace YooAsset.WeChat
{
    [UnityEngine.Scripting.Preserve]
    internal partial class WXFSInitializeOperation : FSInitializeFileSystemOperation
    {
        private readonly WechatFileSystem _fileSystem;

        [UnityEngine.Scripting.Preserve]
        public WXFSInitializeOperation(WechatFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }
        [UnityEngine.Scripting.Preserve]
        public override void InternalOnStart()
        {
            Status = EOperationStatus.Succeed;
        }
        [UnityEngine.Scripting.Preserve]
        public override void InternalOnUpdate()
        {
        }
    }
}
#endif