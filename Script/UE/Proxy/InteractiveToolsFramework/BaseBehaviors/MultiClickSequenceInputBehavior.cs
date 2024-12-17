using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.MultiClickSequenceInputBehavior")]
	public partial class UMultiClickSequenceInputBehavior : UAnyButtonInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.MultiClickSequenceInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}