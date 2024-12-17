using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ExportPakDependenciesCommandlet")]
	public partial class UExportPakDependenciesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ExportPakDependenciesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}