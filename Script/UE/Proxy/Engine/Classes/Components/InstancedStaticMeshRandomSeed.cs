using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InstancedStaticMeshRandomSeed")]
	public partial class FInstancedStaticMeshRandomSeed : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InstancedStaticMeshRandomSeed");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInstancedStaticMeshRandomSeed() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInstancedStaticMeshRandomSeed() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInstancedStaticMeshRandomSeed A, FInstancedStaticMeshRandomSeed B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInstancedStaticMeshRandomSeed A, FInstancedStaticMeshRandomSeed B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInstancedStaticMeshRandomSeed;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int StartInstanceIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StartInstanceIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StartInstanceIndex, __InBuffer);
				}
			}
		}

		public int RandomSeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __InBuffer);
				}
			}
		}

		private static uint __StartInstanceIndex = 0;

		private static uint __RandomSeed = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}