using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.InteractiveCommandResult")]
	public partial class UInteractiveCommandResult : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.InteractiveCommandResult");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}