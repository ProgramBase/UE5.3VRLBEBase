using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Property")]
	public partial class UProperty : UField, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Property");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}