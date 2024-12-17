using Script.CoreUObject;
using Script.Library;

namespace Script.ActorSequence
{
	[PathName("/Script/ActorSequence.ActorSequenceObjectReference")]
	public partial class FActorSequenceObjectReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ActorSequence.ActorSequenceObjectReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorSequenceObjectReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorSequenceObjectReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorSequenceObjectReference A, FActorSequenceObjectReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorSequenceObjectReference A, FActorSequenceObjectReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorSequenceObjectReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EActorSequenceObjectReferenceType Type
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Type, __ReturnBuffer);

					return *(EActorSequenceObjectReferenceType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Type, __InBuffer);
				}
			}
		}

		public FGuid ActorId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorId, __InBuffer);
				}
			}
		}

		public FString PathToComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathToComponent, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathToComponent, __InBuffer);
				}
			}
		}

		private static uint __Type = 0;

		private static uint __ActorId = 0;

		private static uint __PathToComponent = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}