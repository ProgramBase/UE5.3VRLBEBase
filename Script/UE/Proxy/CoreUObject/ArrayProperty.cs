using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ArrayProperty")]
	public partial class UArrayProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ArrayProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}