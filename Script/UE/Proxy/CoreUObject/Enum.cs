using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Enum")]
	public partial class UEnum : UField, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Enum");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}