using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ReplicatedStaticActorDestructionInfo")]
	public partial class FReplicatedStaticActorDestructionInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ReplicatedStaticActorDestructionInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FReplicatedStaticActorDestructionInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FReplicatedStaticActorDestructionInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FReplicatedStaticActorDestructionInfo A, FReplicatedStaticActorDestructionInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FReplicatedStaticActorDestructionInfo A, FReplicatedStaticActorDestructionInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FReplicatedStaticActorDestructionInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UObject> ObjClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjClass, __InBuffer);
				}
			}
		}

		private static uint __ObjClass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}