using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HapticFeedbackEffect_Base")]
	public partial class UHapticFeedbackEffect_Base : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.HapticFeedbackEffect_Base");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}