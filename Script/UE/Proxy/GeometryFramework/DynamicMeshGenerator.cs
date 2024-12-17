using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.DynamicMeshGenerator")]
	public partial class UDynamicMeshGenerator : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.DynamicMeshGenerator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}