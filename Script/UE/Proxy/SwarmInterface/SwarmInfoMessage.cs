using Script.CoreUObject;
using Script.Library;

namespace Script.SwarmInterface
{
	[PathName("/Script/SwarmInterface.SwarmInfoMessage")]
	public partial class FSwarmInfoMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SwarmInterface.SwarmInfoMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwarmInfoMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwarmInfoMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwarmInfoMessage A, FSwarmInfoMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwarmInfoMessage A, FSwarmInfoMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwarmInfoMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString TextMessage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextMessage, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextMessage, __InBuffer);
				}
			}
		}

		private static uint __TextMessage = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}