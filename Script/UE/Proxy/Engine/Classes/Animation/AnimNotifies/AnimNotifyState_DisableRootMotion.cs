using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotifyState_DisableRootMotion")]
	public partial class UAnimNotifyState_DisableRootMotion : UAnimNotifyState, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotifyState_DisableRootMotion");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}