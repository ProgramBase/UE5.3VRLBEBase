using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSetMeshLinkup")]
	public partial class FAnimSetMeshLinkup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSetMeshLinkup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSetMeshLinkup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimSetMeshLinkup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimSetMeshLinkup A, FAnimSetMeshLinkup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSetMeshLinkup A, FAnimSetMeshLinkup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSetMeshLinkup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> BoneToTrackTable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneToTrackTable, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneToTrackTable, __InBuffer);
				}
			}
		}

		private static uint __BoneToTrackTable = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}