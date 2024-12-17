using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingOperatorsEditorOnly
{
	[PathName("/Script/ModelingOperatorsEditorOnly.ParameterizeMeshOperatorFactory")]
	public partial class UParameterizeMeshOperatorFactory : UObject, IStaticClass
	{
		public UParameterizeMeshToolProperties Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UParameterizeMeshToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UVAtlasProperties, __ReturnBuffer);

					return *(UParameterizeMeshToolUVAtlasProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UVAtlasProperties, __InBuffer);
				}
			}
		}

		public UParameterizeMeshToolXAtlasProperties XAtlasProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __XAtlasProperties, __ReturnBuffer);

					return *(UParameterizeMeshToolXAtlasProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __XAtlasProperties, __InBuffer);
				}
			}
		}

		public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PatchBuilderProperties, __ReturnBuffer);

					return *(UParameterizeMeshToolPatchBuilderProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PatchBuilderProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingOperatorsEditorOnly.ParameterizeMeshOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Settings = 0;

		private static uint __UVAtlasProperties = 0;

		private static uint __XAtlasProperties = 0;

		private static uint __PatchBuilderProperties = 0;
	}
}