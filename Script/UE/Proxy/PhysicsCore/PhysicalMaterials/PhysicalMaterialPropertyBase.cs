using Script.CoreUObject;
using Script.Library;

namespace Script.PhysicsCore
{
	[PathName("/Script/PhysicsCore.PhysicalMaterialPropertyBase")]
	public partial class UDEPRECATED_PhysicalMaterialPropertyBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PhysicsCore.PhysicalMaterialPropertyBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}