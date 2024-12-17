using Script.CoreUObject;
using Script.Library;
using Script.MetasoundFrontend;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundPatchBuilder")]
	public partial class UMetaSoundPatchBuilder : UMetaSoundBuilderBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetaSoundPatchBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TScriptInterface<IMetaSoundDocumentInterface> Build(UObject Parent, FMetaSoundBuilderOptions Options)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Options?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __Build, __InBuffer, __ReturnBuffer);

				return *(TScriptInterface<IMetaSoundDocumentInterface>*)__ReturnBuffer;
			}
		}

		private static uint __Build = 0;
	}
}