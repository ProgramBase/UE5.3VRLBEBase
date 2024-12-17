using Script.CoreUObject;
using Script.Library;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AssetToolsHelpers")]
	public partial class UAssetToolsHelpers : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetTools.AssetToolsHelpers");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static TScriptInterface<IAssetTools> GetAssetTools()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAssetTools, __ReturnBuffer);

				return *(TScriptInterface<IAssetTools>*)__ReturnBuffer;
			}
		}

		private static uint __GetAssetTools = 0;
	}
}