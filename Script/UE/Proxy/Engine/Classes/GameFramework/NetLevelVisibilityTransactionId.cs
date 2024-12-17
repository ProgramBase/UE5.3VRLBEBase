using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NetLevelVisibilityTransactionId")]
	public partial class FNetLevelVisibilityTransactionId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NetLevelVisibilityTransactionId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNetLevelVisibilityTransactionId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNetLevelVisibilityTransactionId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNetLevelVisibilityTransactionId A, FNetLevelVisibilityTransactionId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNetLevelVisibilityTransactionId A, FNetLevelVisibilityTransactionId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNetLevelVisibilityTransactionId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		private static uint __Data = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}