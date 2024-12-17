using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TimerHandle")]
	public partial class FTimerHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TimerHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimerHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimerHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimerHandle A, FTimerHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimerHandle A, FTimerHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimerHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ulong Handle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Handle, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Handle, __InBuffer);
				}
			}
		}

		private static uint __Handle = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}