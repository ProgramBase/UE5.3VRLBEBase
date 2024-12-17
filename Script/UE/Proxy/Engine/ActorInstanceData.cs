using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorInstanceData")]
	public partial class FActorInstanceData : FInstanceCacheDataBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActorInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorInstanceData()
		{
		}

		public static bool operator ==(FActorInstanceData A, FActorInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorInstanceData A, FActorInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<AActor> ActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorClass, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorClass, __InBuffer);
				}
			}
		}

		private static uint __ActorClass = 0;

	}
}