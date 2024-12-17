using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIMoveRequest")]
	public partial class FAIMoveRequest : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AIMoveRequest");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAIMoveRequest() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAIMoveRequest() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAIMoveRequest A, FAIMoveRequest B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAIMoveRequest A, FAIMoveRequest B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAIMoveRequest;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<AActor> GoalActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GoalActor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GoalActor, __InBuffer);
				}
			}
		}

		private static uint __GoalActor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}