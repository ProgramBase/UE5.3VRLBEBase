using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletonToMeshLinkup")]
	public partial class FSkeletonToMeshLinkup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkeletonToMeshLinkup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletonToMeshLinkup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkeletonToMeshLinkup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkeletonToMeshLinkup A, FSkeletonToMeshLinkup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletonToMeshLinkup A, FSkeletonToMeshLinkup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletonToMeshLinkup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> SkeletonToMeshTable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkeletonToMeshTable, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkeletonToMeshTable, __InBuffer);
				}
			}
		}

		public TArray<int> MeshToSkeletonTable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshToSkeletonTable, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshToSkeletonTable, __InBuffer);
				}
			}
		}

		private static uint __SkeletonToMeshTable = 0;

		private static uint __MeshToSkeletonTable = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}