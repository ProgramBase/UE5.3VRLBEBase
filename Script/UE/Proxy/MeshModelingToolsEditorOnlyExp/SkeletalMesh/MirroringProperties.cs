using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.SkeletalMeshModifiers;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.MirroringProperties")]
	public partial class UMirroringProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public FMirrorOptions Options
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Options, __ReturnBuffer);

					return *(FMirrorOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Options, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.MirroringProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Options = 0;
	}
}