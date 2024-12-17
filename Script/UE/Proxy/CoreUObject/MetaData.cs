using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.MetaData")]
	public partial class UMetaData : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.MetaData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}