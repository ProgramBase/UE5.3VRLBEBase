using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldSystemMetaData")]
	public partial class UFieldSystemMetaData : UActorComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldSystemMetaData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}