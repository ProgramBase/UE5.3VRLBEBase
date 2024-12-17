using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.TestUninitializedScriptStructMembersTest")]
	public partial class FTestUninitializedScriptStructMembersTest : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.TestUninitializedScriptStructMembersTest");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTestUninitializedScriptStructMembersTest() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTestUninitializedScriptStructMembersTest() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTestUninitializedScriptStructMembersTest A, FTestUninitializedScriptStructMembersTest B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTestUninitializedScriptStructMembersTest A, FTestUninitializedScriptStructMembersTest B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTestUninitializedScriptStructMembersTest;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject UninitializedObjectReference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UninitializedObjectReference, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UninitializedObjectReference, __InBuffer);
				}
			}
		}

		public UObject InitializedObjectReference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitializedObjectReference, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitializedObjectReference, __InBuffer);
				}
			}
		}

		public float UnusedValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UnusedValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UnusedValue, __InBuffer);
				}
			}
		}

		private static uint __UninitializedObjectReference = 0;

		private static uint __InitializedObjectReference = 0;

		private static uint __UnusedValue = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}