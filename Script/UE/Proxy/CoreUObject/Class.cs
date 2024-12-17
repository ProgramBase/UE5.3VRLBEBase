using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Class")]
	public partial class UClass : UStruct, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Class");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}