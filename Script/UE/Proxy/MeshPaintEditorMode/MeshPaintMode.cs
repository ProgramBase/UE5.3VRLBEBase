using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MeshPaintEditorMode
{
	[PathName("/Script/MeshPaintEditorMode.MeshPaintMode")]
	public partial class UMeshPaintMode : UEdMode, IStaticClass, ILegacyEdModeViewportInterface
	{
		public UMeshPaintModeSettings ModeSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModeSettings, __ReturnBuffer);

					return *(UMeshPaintModeSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModeSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintEditorMode.MeshPaintMode");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __ModeSettings = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}