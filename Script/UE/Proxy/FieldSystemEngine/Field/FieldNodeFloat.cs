using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldNodeFloat")]
	public partial class UFieldNodeFloat : UFieldNodeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldNodeFloat");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}