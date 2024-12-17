using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.BoundActorProxy")]
	public partial class FBoundActorProxy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.BoundActorProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoundActorProxy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoundActorProxy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoundActorProxy A, FBoundActorProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoundActorProxy A, FBoundActorProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoundActorProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public AActor BoundActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoundActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoundActor, __InBuffer);
				}
			}
		}

		private static uint __BoundActor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}