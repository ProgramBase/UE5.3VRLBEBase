using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.LODInfoUILayout")]
	public partial class ULODInfoUILayout : UObject, IStaticClass
	{
		public FSkeletalMeshLODInfo LODInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODInfo, __ReturnBuffer);

					return *(FSkeletalMeshLODInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODInfo, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.LODInfoUILayout");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LODInfo = 0;
	}
}