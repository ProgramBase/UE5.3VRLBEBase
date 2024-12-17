using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MergeActors
{
	[PathName("/Script/MergeActors.MeshApproximationSettingsObject")]
	public partial class UMeshApproximationSettingsObject : UObject, IStaticClass
	{
		public FMeshApproximationSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FMeshApproximationSettings*)__ReturnBuffer;
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MergeActors.MeshApproximationSettingsObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Settings = 0;
	}
}