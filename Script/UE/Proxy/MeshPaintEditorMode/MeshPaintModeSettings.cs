using Script.CoreUObject;
using Script.MeshPaintingToolset;
using Script.Library;

namespace Script.MeshPaintEditorMode
{
	[PathName("/Script/MeshPaintEditorMode.MeshPaintModeSettings")]
	public partial class UMeshPaintModeSettings : UObject, IStaticClass
	{
		public EMeshPaintDataColorViewMode ColorViewMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorViewMode, __ReturnBuffer);

					return *(EMeshPaintDataColorViewMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorViewMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintEditorMode.MeshPaintModeSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ColorViewMode = 0;
	}
}