using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundNodeHandle")]
	public partial class FMetaSoundNodeHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEngine.MetaSoundNodeHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundNodeHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetaSoundNodeHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetaSoundNodeHandle A, FMetaSoundNodeHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundNodeHandle A, FMetaSoundNodeHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundNodeHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid NodeID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeID, __InBuffer);
				}
			}
		}

		private static uint __NodeID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}