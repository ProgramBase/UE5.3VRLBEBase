using Script.CoreUObject;
using Script.Library;

namespace Script.ToolWidgets
{
	[PathName("/Script/ToolWidgets.FilterBarContext")]
	public partial class UFilterBarContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolWidgets.FilterBarContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}