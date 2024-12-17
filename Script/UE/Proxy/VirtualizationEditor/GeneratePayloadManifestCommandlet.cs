using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VirtualizationEditor
{
	[PathName("/Script/VirtualizationEditor.GeneratePayloadManifestCommandlet")]
	public partial class UGeneratePayloadManifestCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VirtualizationEditor.GeneratePayloadManifestCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}