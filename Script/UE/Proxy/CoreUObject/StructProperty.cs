using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.StructProperty")]
	public partial class UStructProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.StructProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}