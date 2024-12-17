using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldNodeVector")]
	public partial class UFieldNodeVector : UFieldNodeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldNodeVector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}