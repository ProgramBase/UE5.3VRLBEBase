using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.SlateTypes")]
	public partial class USlateTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SlateCore.SlateTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}