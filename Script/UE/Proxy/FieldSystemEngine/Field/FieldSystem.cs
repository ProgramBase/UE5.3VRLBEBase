using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldSystem")]
	public partial class UFieldSystem : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldSystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}