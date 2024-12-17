using Script.CoreUObject;
using Script.Library;

namespace Script.ActorSequence
{
	[PathName("/Script/ActorSequence.ActorSequenceObjectReferences")]
	public partial class FActorSequenceObjectReferences : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ActorSequence.ActorSequenceObjectReferences");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorSequenceObjectReferences() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorSequenceObjectReferences() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorSequenceObjectReferences A, FActorSequenceObjectReferences B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorSequenceObjectReferences A, FActorSequenceObjectReferences B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorSequenceObjectReferences;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FActorSequenceObjectReference> Array
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Array, __ReturnBuffer);

					return *(TArray<FActorSequenceObjectReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Array, __InBuffer);
				}
			}
		}

		private static uint __Array = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}