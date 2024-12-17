using Script.CoreUObject;
using Script.Library;

namespace Script.NetCore
{
	[PathName("/Script/NetCore.StateStruct")]
	public partial class FStateStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NetCore.StateStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStateStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStateStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStateStruct A, FStateStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStateStruct A, FStateStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStateStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString StateName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StateName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StateName, __InBuffer);
				}
			}
		}

		private static uint __StateName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}