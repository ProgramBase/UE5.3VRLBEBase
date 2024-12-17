using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkelMeshComponentLODInfo")]
	public partial class FSkelMeshComponentLODInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkelMeshComponentLODInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkelMeshComponentLODInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkelMeshComponentLODInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkelMeshComponentLODInfo A, FSkelMeshComponentLODInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkelMeshComponentLODInfo A, FSkelMeshComponentLODInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkelMeshComponentLODInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<bool> HiddenMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HiddenMaterials, __ReturnBuffer);

					return *(TArray<bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HiddenMaterials, __InBuffer);
				}
			}
		}

		private static uint __HiddenMaterials = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}