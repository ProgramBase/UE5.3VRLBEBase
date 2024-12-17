using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolFlushEmbeddedGeometrySettings")]
	public partial class UFractureToolFlushEmbeddedGeometrySettings : UFractureToolSettings, IStaticClass
	{
		public bool bExtractAsStaticMeshActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExtractAsStaticMeshActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExtractAsStaticMeshActors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolFlushEmbeddedGeometrySettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bExtractAsStaticMeshActors = 0;
	}
}