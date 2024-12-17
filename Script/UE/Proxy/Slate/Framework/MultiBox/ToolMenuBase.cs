using Script.CoreUObject;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.ToolMenuBase")]
	public partial class UToolMenuBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.ToolMenuBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}