using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EventGraphFastCallPair")]
	public partial class FEventGraphFastCallPair : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.EventGraphFastCallPair");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEventGraphFastCallPair() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEventGraphFastCallPair() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEventGraphFastCallPair A, FEventGraphFastCallPair B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEventGraphFastCallPair A, FEventGraphFastCallPair B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEventGraphFastCallPair;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UFunction FunctionToPatch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionToPatch, __ReturnBuffer);

					return *(UFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionToPatch, __InBuffer);
				}
			}
		}

		public int EventGraphCallOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventGraphCallOffset, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventGraphCallOffset, __InBuffer);
				}
			}
		}

		private static uint __FunctionToPatch = 0;

		private static uint __EventGraphCallOffset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}