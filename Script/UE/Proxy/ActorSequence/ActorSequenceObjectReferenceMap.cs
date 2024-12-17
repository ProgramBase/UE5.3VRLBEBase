using Script.CoreUObject;
using Script.Library;

namespace Script.ActorSequence
{
	[PathName("/Script/ActorSequence.ActorSequenceObjectReferenceMap")]
	public partial class FActorSequenceObjectReferenceMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ActorSequence.ActorSequenceObjectReferenceMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorSequenceObjectReferenceMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorSequenceObjectReferenceMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorSequenceObjectReferenceMap A, FActorSequenceObjectReferenceMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorSequenceObjectReferenceMap A, FActorSequenceObjectReferenceMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorSequenceObjectReferenceMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FGuid> BindingIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingIds, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingIds, __InBuffer);
				}
			}
		}

		public TArray<FActorSequenceObjectReferences> References
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __References, __ReturnBuffer);

					return *(TArray<FActorSequenceObjectReferences>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __References, __InBuffer);
				}
			}
		}

		private static uint __BindingIds = 0;

		private static uint __References = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}