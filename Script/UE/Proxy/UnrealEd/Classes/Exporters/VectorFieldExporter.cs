using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VectorFieldExporter")]
	public partial class UVectorFieldExporter : UExporter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VectorFieldExporter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}