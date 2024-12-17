using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithCADImportSceneData")]
	public partial class UDatasmithCADImportSceneData : UDatasmithSceneImportData, IStaticClass
	{
		public FDatasmithTessellationOptions TessellationOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TessellationOptions, __ReturnBuffer);

					return *(FDatasmithTessellationOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TessellationOptions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithCADImportSceneData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TessellationOptions = 0;
	}
}