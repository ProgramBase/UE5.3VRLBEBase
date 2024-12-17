using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldNodeBase")]
	public partial class UFieldNodeBase : UActorComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldNodeBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}