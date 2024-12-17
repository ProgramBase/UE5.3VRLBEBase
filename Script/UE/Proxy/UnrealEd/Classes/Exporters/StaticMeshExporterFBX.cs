using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.StaticMeshExporterFBX")]
	public partial class UStaticMeshExporterFBX : UExporterFBX, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.StaticMeshExporterFBX");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}