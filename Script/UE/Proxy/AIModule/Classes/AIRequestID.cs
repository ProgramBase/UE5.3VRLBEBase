using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIRequestID")]
	public partial class FAIRequestID : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.AIRequestID");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAIRequestID() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAIRequestID() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAIRequestID A, FAIRequestID B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAIRequestID A, FAIRequestID B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAIRequestID;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint RequestID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RequestID, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RequestID, __InBuffer);
				}
			}
		}

		private static uint __RequestID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}