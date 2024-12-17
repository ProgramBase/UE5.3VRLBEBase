using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveCommandArguments")]
	public partial class UInteractiveCommandArguments : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveCommandArguments");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}