using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharpCore
{
	[PathName("/Script/UnrealCSharpCore.DynamicScriptStruct")]
	public partial class UDynamicScriptStruct : UScriptStruct, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealCSharpCore.DynamicScriptStruct");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}