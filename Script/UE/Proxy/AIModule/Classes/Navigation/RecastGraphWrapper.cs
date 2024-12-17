using Script.CoreUObject;
using Script.Library;
using Script.NavigationSystem;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.RecastGraphWrapper")]
	public partial class FRecastGraphWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.RecastGraphWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRecastGraphWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRecastGraphWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRecastGraphWrapper A, FRecastGraphWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRecastGraphWrapper A, FRecastGraphWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRecastGraphWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ARecastNavMesh RecastNavMeshActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RecastNavMeshActor, __ReturnBuffer);

					return *(ARecastNavMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RecastNavMeshActor, __InBuffer);
				}
			}
		}

		private static uint __RecastNavMeshActor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}