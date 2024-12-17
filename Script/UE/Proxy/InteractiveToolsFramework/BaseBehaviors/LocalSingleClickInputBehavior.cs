using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.LocalSingleClickInputBehavior")]
	public partial class ULocalSingleClickInputBehavior : USingleClickInputBehavior, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.LocalSingleClickInputBehavior");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}