using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.ActorPerceptionUpdateInfo")]
	public partial class FActorPerceptionUpdateInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.ActorPerceptionUpdateInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorPerceptionUpdateInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorPerceptionUpdateInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorPerceptionUpdateInfo A, FActorPerceptionUpdateInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorPerceptionUpdateInfo A, FActorPerceptionUpdateInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorPerceptionUpdateInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int TargetId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetId, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetId, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<AActor> Target
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Target, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Target, __InBuffer);
				}
			}
		}

		public FAIStimulus Stimulus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Stimulus, __ReturnBuffer);

					return *(FAIStimulus*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Stimulus, __InBuffer);
				}
			}
		}

		private static uint __TargetId = 0;

		private static uint __Target = 0;

		private static uint __Stimulus = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}