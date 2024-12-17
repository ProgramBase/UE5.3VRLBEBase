using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharp
{
	[PathName("/Script/UnrealCSharp.CSharpFunction")]
	public partial class UCSharpFunction : UFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealCSharp.CSharpFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}