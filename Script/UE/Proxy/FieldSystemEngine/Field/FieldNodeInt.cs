using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldNodeInt")]
	public partial class UFieldNodeInt : UFieldNodeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldNodeInt");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}