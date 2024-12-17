using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.GCObjectReferencer")]
	public partial class UGCObjectReferencer : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.GCObjectReferencer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}