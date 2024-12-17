using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.SetProperty")]
	public partial class USetProperty : UProperty, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.SetProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}